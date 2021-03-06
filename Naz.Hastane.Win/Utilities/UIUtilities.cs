﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data;
using Naz.Hastane.Reports;
using Naz.Hastane.Reports.Classes;
using Naz.Utilities.Classes;
using NHibernate;
using Nini.Config;
using System.IO;
using System.Windows.Forms;
using System.Linq.Expressions;
using Naz.Classes;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win
{
    public static class UIUtilities
    {
        public static User CurrentUser = null;
        
        public static string CurrentPrinter = null;
        public static string CurrentPrinterTray = null;

        //public static void BindLookUpEdit(LookUpEdit lue, Object dataSourceList,
        //    string displayMember = "Value", string valueMember = "ID")
        //{
        //    lue.Properties.DisplayMember = displayMember;
        //    lue.Properties.ValueMember = valueMember;
        //    lue.Properties.DataSource = dataSourceList;
        //}

        public static void BindLookUpEdit<T>(LookUpEdit lue, IList<T> dataSourceList,
            string displayMember = "Value", string valueMember = "Code", string initialValue = "") where T : new()
        {
            lue.Properties.Columns.Clear();
            lue.Properties.DisplayMember = displayMember;
            lue.Properties.ValueMember = valueMember;
            lue.Properties.Columns.Add(new LookUpColumnInfo("Code", 10, "Kod"));
            lue.Properties.Columns.Add(new LookUpColumnInfo("Value", 30, typeof(T).GetDescription()));
            lue.Properties.DataSource = dataSourceList;
            if (!String.IsNullOrWhiteSpace(initialValue))
                lue.EditValue = initialValue;
            else
                lue.ItemIndex = 0;
        }

        //public static void BindComboBox<T>(System.Windows.Forms.ComboBox comboBox, IList<T> dataSourceList,
        //    string displayMember = "Value", string valueMember = "Code") where T : new()
        //{
        //    comboBox.DisplayMember = displayMember;
        //    //comboBox.ValueMember = valueMember;
        //    comboBox.DataSource = new BindingSource() { DataSource = new NullSafeBindingList<T>(dataSourceList, valueMember, displayMember)  };
        //    //if (dataSourceList.Count > 0)
        //    //    lue.ItemIndex = 0;
        //}

        public static void BindComboBox<T>(System.Windows.Forms.ComboBox comboBox, IList<T> dataSourceList,
            Expression<Func<T, object>> displayMember, Expression<Func<T, object>> valueMember) where T : new()
        {
            comboBox.DisplayMember = DataUtilities.GetMemberName<T>(displayMember);
            //comboBox.ValueMember = valueMember;
            comboBox.DataSource = new BindingSource() 
            {
                DataSource = new NullSafeBindingList<T>(dataSourceList, DataUtilities.GetMemberName<T>(valueMember), DataUtilities.GetMemberName<T>(displayMember))
            };
            //if (dataSourceList.Count > 0)
            //    lue.ItemIndex = 0;
        }

        public static void BindLookUpEditAllColumns<T>(LookUpEdit lue, IList<T> dataSourceList) where T : new()
        {
            lue.Properties.Columns.Clear();
            lue.Properties.DisplayMember = "Value";
            lue.Properties.ValueMember = "Code";

            foreach (var md in ReflectionUtilities.MemberDescriptions<T>())
            {
                lue.Properties.Columns.Add(new LookUpColumnInfo(md.Key, md.Value));
            }
            lue.Properties.DataSource = dataSourceList;
        }

        public static void BindGrid<T>(GridView view, IList<T> dataSourceList) where T : new()
        {
            view.Columns.Clear();

            foreach (var md in ReflectionUtilities.MemberDescriptions<T>())
            {
                GridColumn column = view.Columns.AddField(md.Key);
                column.Caption = md.Value;
                column.Visible = true;
            }
            view.GridControl.DataSource = dataSourceList;
        }

        public static void BindControl<T>(Control control, T t, Expression<Func<T, object>> memberExpression, string propertyName = "EditValue")
        {
            control.DataBindings.Clear();
            control.DataBindings.Add(propertyName, t, DataUtilities.GetMemberName<T>(memberExpression), true);
        }

        private static IConfigSource _Configuration = null;
        public static IConfigSource ConfigurationSource
        {
            get
            {
                if (_Configuration == null)
                {
                    string appPath = Application.StartupPath;
                    appPath = Path.Combine(appPath, "Naz.Hastane.ini");
                    _Configuration = new IniConfigSource(appPath);
                    if (_Configuration.Configs["User"] == null)
                    {
                        _Configuration.AddConfig("User");
                        _Configuration.Save();
                    }
                    
                }
                return _Configuration;
            }
        }

        public static void SetPrintTray(PrintDocument doc, string printerName, string trayName)
        {
            if (IsPrinterExist(printerName))
            {
                doc.PrinterSettings.PrinterName = printerName;
                foreach(PaperSource ps in doc.PrinterSettings.PaperSources)
                {
                    if (ps.SourceName == trayName)
                    {
                        doc.DefaultPageSettings.PaperSource = ps;
                        break;
                    }
                }
            }
        }

        public static bool IsPrinterExist(string printerName)
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
                if (printer == printerName)
                    return true;
            return false;
        }

        public static List<string> GetPrinters()
        {
            List<string> printers = new List<string>();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printers.Add(printer);
            }
            return printers;
        }

        public static List<string> GetPrinterTrays(string printerName)
        {
            PrinterSettings printer = new PrinterSettings();
            printer.PrinterName = printerName;

            List<string> paperSources = new List<string>();
            if (printer.IsValid)
            {
                foreach (PaperSource paperSource in printer.PaperSources)
                {
                    paperSources.Add(paperSource.SourceName);
                }
            }
            return paperSources;
        }

        public static void PrintInvoice(ISession session, Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, double advancePaymentUsed, string tellerInvoiceNo, bool directPrint)
        {
            if (pvds.Count == 0)
                return;

            try
            {
                PatientVisit pv = pvds[0].PatientVisit;

                PatientServices.AddNewInvoice(session, GetInvoiceUser(), patient, pvds,
                    paymentType, POSType,
                    productTotal, VATTotal, invoiceTotal, discountTotal, VATPercent,
                    cashPayment, advancePaymentUsed, tellerInvoiceNo);

                InvoiceSGK rpt = new InvoiceSGK();
                rpt.prmAddress.Value = patient.HomeInvoiceAddress;
                rpt.prmDate.Value = DateTime.Now;
                rpt.prmDoctor.Value = pv.Doctor.Value;
                rpt.prmInvoiceNo.Value = tellerInvoiceNo;
                rpt.prmPatientNo.Value = patient.PatientNo;
                rpt.prmPatientPrice.Value = productTotal;
                rpt.prmPatientTotal.Value = productTotal;
                rpt.prmQueueNo.Value = pv.QueueNo;
                rpt.prmServiceNo.Value = pv.Servis;
                rpt.prmTaxOffice.Value = "";
                rpt.prmTCID.Value = patient.TCId;
                rpt.prmTime.Value = DateTime.Now;
                rpt.prmTotal.Value = invoiceTotal;
                rpt.prmTotalText.Value = Helpers.GetMoneyToTrString(invoiceTotal.ToString());
                rpt.prmVAT.Value = VATPercent;
                rpt.prmVATValue.Value = VATTotal;

                CurrentPrinter = ConfigurationSource.Configs["Printer"].Get("InvoicePrinter", "");
                CurrentPrinterTray = ConfigurationSource.Configs["Printer"].Get("InvoicePrinterTray", "");

                PrintReport(rpt, directPrint);
            }
            catch (Exception e)
            {
                SimpleMsgBoxForm.ShowMsgBox("Fatura Yazma Hatası: " + e.Message, "Uyarı Ekranı", true);
            } 
        }

        public static User GetInvoiceUser()
        {
            string userName = ConfigurationSource.Configs["User"].Get("InvoiceUser", "");
            User user = LookUpServices.GetByID<User>(userName);
            if (user == null)
                return CurrentUser;
            else
                return user;
        }

        /// <summary>
        /// Fatura Basımı
        /// </summary>
        /// <param name="session"></param>
        /// <param name="patient"></param>
        /// <param name="pvds"></param>
        /// <param name="paymentType"></param>
        /// <param name="POSType"></param>
        /// <param name="paymentTotal"></param>
        /// <param name="tellerVoucherNo"></param>
        /// <param name="directPrint"></param>
        public static void PrintVoucher(ISession session, Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double paymentTotal, string tellerVoucherNo, bool directPrint)
        {
            if (pvds.Count == 0)
                return;

            try
            {
                PatientServices.AddNewVoucher(session, GetVoucherUser(), pvds,
                    paymentType, POSType,
                    paymentTotal,
                    tellerVoucherNo
                    );

                VoucherSGK rpt = new VoucherSGK();
                rpt.prmDate.Value = DateTime.Now;
                rpt.prmPatientName.Value = patient.FullName;
                rpt.prmPatientNo.Value = patient.PatientNo;
                rpt.prmDoctor.Value = String.Format("({0}) {1}", pvds[0].PatientVisit.Doctor.Code, pvds[0].PatientVisit.Doctor.Value);
                rpt.prmTCID.Value = patient.TCId;
                rpt.prmTime.Value = DateTime.Now;
                rpt.prmTotal.Value = paymentTotal;
                rpt.prmTotalText.Value = Helpers.GetMoneyToTrString(paymentTotal.ToString());
                rpt.prmUserID.Value = GetVoucherUser().USER_ID;
                rpt.prmVoucherNo.Value = tellerVoucherNo;

                CurrentPrinter = ConfigurationSource.Configs["Printer"].Get("VoucherPrinter", "");
                CurrentPrinterTray = ConfigurationSource.Configs["Printer"].Get("VoucherPrinterTray", "");
                PrintReport(rpt, directPrint);

            }
            catch (Exception e)
            {
                SimpleMsgBoxForm.ShowMsgBox("Makbuz Yazma Hatası: " + e.Message, "Uyarı Ekranı", true);
            }
        }

        public static User GetVoucherUser()
        {
            string userName = ConfigurationSource.Configs["User"].Get("VoucherUser", "");
            User user = LookUpServices.GetByID<User>(userName);
            if (user == null)
                return CurrentUser;
            else
                return user;
        }


        public static void PrintTaahhutname(Patient patient, bool directPrint)
        {
            SGKTaahhutnameReport rpt = new SGKTaahhutnameReport();

            rpt.prmHomeAddress.Value = patient.HomeAddress;
            rpt.prmHomeCity.Value = patient.HomeCity;
            rpt.prmHomeDistrict.Value = patient.HomeDistrict;
            rpt.prmHomeTown.Value = patient.HomeTown;
            rpt.prmPatientName.Value = patient.FullName;
            rpt.prmPatientNo.Value = patient.PatientNo;
            rpt.prmPhone1.Value = patient.HomePhone1;
            rpt.prmPhone2.Value = patient.HomePhone2;
            rpt.prmPrintDate.Value = DateTime.Today;
            rpt.prmTCID.Value = patient.TCId;

            CurrentPrinter = ConfigurationSource.Configs["Printer"].Get("NormalPrinter", "");
            CurrentPrinterTray = ConfigurationSource.Configs["Printer"].Get("NormalPrinterTray", "");
            PrintReport(rpt, directPrint);
        }

        public static void PrintReport(XtraReport rpt, bool directPrint)
        {
            if (directPrint)
            {
                rpt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(printingSystem_StartPrint);
                rpt.Print();

            }
            else
            {
                rpt.ShowPreview();
            }
        }

        private static void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e)
        {
            UIUtilities.SetPrintTray(e.PrintDocument, CurrentPrinter,  CurrentPrinterTray);
        }

    }
}
