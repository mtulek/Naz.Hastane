﻿namespace Naz.Hastane.Win.MDIChildForms
{
    partial class PersonelAraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbNew = new DevExpress.XtraEditors.SimpleButton();
            this.lcHastaAdeti = new DevExpress.XtraEditors.LabelControl();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbClean = new DevExpress.XtraEditors.SimpleButton();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.sbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gridPersonelArama = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKNR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tePersonnelNo = new DevExpress.XtraEditors.TextEdit();
            this.teTCId = new DevExpress.XtraEditors.TextEdit();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.lcgSayfa = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBulunanHastalar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgAramaKriterleri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grpHastaNo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPatientNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTCId = new DevExpress.XtraLayout.LayoutControlItem();
            this.grpSNR = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgTuslar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSelect = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClean = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHastaAdeti = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonelArama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePersonnelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBulunanHastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAramaKriterleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpHastaNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTuslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHastaAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbNew);
            this.layoutControl1.Controls.Add(this.lcHastaAdeti);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbClean);
            this.layoutControl1.Controls.Add(this.teLastName);
            this.layoutControl1.Controls.Add(this.teFirstName);
            this.layoutControl1.Controls.Add(this.sbSearch);
            this.layoutControl1.Controls.Add(this.gridPersonelArama);
            this.layoutControl1.Controls.Add(this.tePersonnelNo);
            this.layoutControl1.Controls.Add(this.teTCId);
            this.layoutControl1.Controls.Add(this.sbSelect);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1558, -113, 549, 703);
            this.layoutControl1.Root = this.lcgSayfa;
            this.layoutControl1.Size = new System.Drawing.Size(954, 638);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbNew
            // 
            this.sbNew.Location = new System.Drawing.Point(731, 76);
            this.sbNew.Name = "sbNew";
            this.sbNew.Size = new System.Drawing.Size(96, 22);
            this.sbNew.StyleController = this.layoutControl1;
            this.sbNew.TabIndex = 8;
            this.sbNew.Text = "Yeni";
            this.sbNew.Click += new System.EventHandler(this.sbNew_Click);
            // 
            // lcHastaAdeti
            // 
            this.lcHastaAdeti.Location = new System.Drawing.Point(894, 613);
            this.lcHastaAdeti.Name = "lcHastaAdeti";
            this.lcHastaAdeti.Size = new System.Drawing.Size(48, 13);
            this.lcHastaAdeti.StyleController = this.layoutControl1;
            this.lcHastaAdeti.TabIndex = 21;
            this.lcHastaAdeti.Text = "Bulunan:0";
            // 
            // sbClose
            // 
            this.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbClose.Location = new System.Drawing.Point(831, 50);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(99, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 10;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbClean
            // 
            this.sbClean.Location = new System.Drawing.Point(831, 24);
            this.sbClean.Name = "sbClean";
            this.sbClean.Size = new System.Drawing.Size(99, 22);
            this.sbClean.StyleController = this.layoutControl1;
            this.sbClean.TabIndex = 9;
            this.sbClean.Text = "Temizle";
            this.sbClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(475, 60);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teLastName.Size = new System.Drawing.Size(216, 20);
            this.teLastName.StyleController = this.layoutControl1;
            this.teLastName.TabIndex = 4;
            this.teLastName.Tag = "HASTASOYADI";
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(475, 36);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teFirstName.Size = new System.Drawing.Size(216, 20);
            this.teFirstName.StyleController = this.layoutControl1;
            this.teFirstName.TabIndex = 3;
            this.teFirstName.Tag = "HASTAADI";
            // 
            // sbSearch
            // 
            this.sbSearch.Location = new System.Drawing.Point(731, 24);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Size = new System.Drawing.Size(96, 22);
            this.sbSearch.StyleController = this.layoutControl1;
            this.sbSearch.TabIndex = 6;
            this.sbSearch.Text = "Ara";
            this.sbSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridPersonelArama
            // 
            this.gridPersonelArama.Location = new System.Drawing.Point(12, 130);
            this.gridPersonelArama.MainView = this.gridView1;
            this.gridPersonelArama.Name = "gridPersonelArama";
            this.gridPersonelArama.Size = new System.Drawing.Size(930, 479);
            this.gridPersonelArama.TabIndex = 11;
            this.gridPersonelArama.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridPersonelArama.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridPersonelArama_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colKNR,
            this.colSoyadi,
            this.colAdi,
            this.colTCKimlikNo});
            this.gridView1.GridControl = this.gridPersonelArama;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colKNR
            // 
            this.colKNR.Caption = "Personel No";
            this.colKNR.FieldName = "PersonelNo";
            this.colKNR.Name = "colKNR";
            this.colKNR.Visible = true;
            this.colKNR.VisibleIndex = 0;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyad";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Ad";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 2;
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.Caption = "T.C. Kimlik No";
            this.colTCKimlikNo.FieldName = "TCID";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.VisibleIndex = 3;
            // 
            // tePersonnelNo
            // 
            this.tePersonnelNo.Location = new System.Drawing.Point(121, 60);
            this.tePersonnelNo.Name = "tePersonnelNo";
            this.tePersonnelNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePersonnelNo.Size = new System.Drawing.Size(241, 20);
            this.tePersonnelNo.StyleController = this.layoutControl1;
            this.tePersonnelNo.TabIndex = 2;
            this.tePersonnelNo.Tag = "KNR";
            // 
            // teTCId
            // 
            this.teTCId.Location = new System.Drawing.Point(121, 36);
            this.teTCId.Name = "teTCId";
            this.teTCId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teTCId.Size = new System.Drawing.Size(241, 20);
            this.teTCId.StyleController = this.layoutControl1;
            this.teTCId.TabIndex = 1;
            this.teTCId.Tag = "TCKIMLIKNO";
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(731, 50);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(96, 22);
            this.sbSelect.StyleController = this.layoutControl1;
            this.sbSelect.TabIndex = 7;
            this.sbSelect.Text = "Seç";
            this.sbSelect.Click += new System.EventHandler(this.bntSelect_Click);
            // 
            // lcgSayfa
            // 
            this.lcgSayfa.CustomizationFormText = "Sayfa";
            this.lcgSayfa.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgSayfa.GroupBordersVisible = false;
            this.lcgSayfa.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBulunanHastalar,
            this.lcgAramaKriterleri,
            this.lcgTuslar,
            this.lciHastaAdeti});
            this.lcgSayfa.Location = new System.Drawing.Point(0, 0);
            this.lcgSayfa.Name = "lcgSayfa";
            this.lcgSayfa.Size = new System.Drawing.Size(954, 638);
            this.lcgSayfa.Text = "Sayfa";
            this.lcgSayfa.TextVisible = false;
            // 
            // lciBulunanHastalar
            // 
            this.lciBulunanHastalar.Control = this.gridPersonelArama;
            this.lciBulunanHastalar.CustomizationFormText = "Bulunan Personels";
            this.lciBulunanHastalar.Location = new System.Drawing.Point(0, 102);
            this.lciBulunanHastalar.Name = "lciBulunanHastalar";
            this.lciBulunanHastalar.Size = new System.Drawing.Size(934, 499);
            this.lciBulunanHastalar.Text = "Bulunan Hastalar";
            this.lciBulunanHastalar.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciBulunanHastalar.TextSize = new System.Drawing.Size(81, 13);
            // 
            // lcgAramaKriterleri
            // 
            this.lcgAramaKriterleri.CustomizationFormText = "Arama Kriterleri";
            this.lcgAramaKriterleri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grpHastaNo,
            this.grpSNR});
            this.lcgAramaKriterleri.Location = new System.Drawing.Point(0, 0);
            this.lcgAramaKriterleri.Name = "lcgAramaKriterleri";
            this.lcgAramaKriterleri.Size = new System.Drawing.Size(707, 102);
            this.lcgAramaKriterleri.Text = "Arama Kriterleri";
            this.lcgAramaKriterleri.TextVisible = false;
            // 
            // grpHastaNo
            // 
            this.grpHastaNo.CustomizationFormText = "Patient No";
            this.grpHastaNo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPatientNo,
            this.lciTCId});
            this.grpHastaNo.Location = new System.Drawing.Point(0, 0);
            this.grpHastaNo.Name = "grpHastaNo";
            this.grpHastaNo.Size = new System.Drawing.Size(354, 78);
            this.grpHastaNo.Text = "Patient No";
            this.grpHastaNo.TextVisible = false;
            // 
            // lciPatientNo
            // 
            this.lciPatientNo.Control = this.tePersonnelNo;
            this.lciPatientNo.CustomizationFormText = "Hasta No";
            this.lciPatientNo.Location = new System.Drawing.Point(0, 24);
            this.lciPatientNo.Name = "lciPatientNo";
            this.lciPatientNo.Size = new System.Drawing.Size(330, 30);
            this.lciPatientNo.Text = "Personel No";
            this.lciPatientNo.TextSize = new System.Drawing.Size(81, 13);
            // 
            // lciTCId
            // 
            this.lciTCId.Control = this.teTCId;
            this.lciTCId.CustomizationFormText = "T.C.Kimlik No";
            this.lciTCId.Location = new System.Drawing.Point(0, 0);
            this.lciTCId.Name = "lciTCId";
            this.lciTCId.Size = new System.Drawing.Size(330, 24);
            this.lciTCId.Text = "T.C.Kimlik No";
            this.lciTCId.TextSize = new System.Drawing.Size(81, 13);
            // 
            // grpSNR
            // 
            this.grpSNR.CustomizationFormText = "SNR";
            this.grpSNR.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFirstName,
            this.lciLastName});
            this.grpSNR.Location = new System.Drawing.Point(354, 0);
            this.grpSNR.Name = "grpSNR";
            this.grpSNR.Size = new System.Drawing.Size(329, 78);
            this.grpSNR.Text = "SNR";
            this.grpSNR.TextVisible = false;
            // 
            // lciFirstName
            // 
            this.lciFirstName.Control = this.teFirstName;
            this.lciFirstName.CustomizationFormText = "Adı";
            this.lciFirstName.Location = new System.Drawing.Point(0, 0);
            this.lciFirstName.Name = "lciFirstName";
            this.lciFirstName.Size = new System.Drawing.Size(305, 24);
            this.lciFirstName.Text = "Adı";
            this.lciFirstName.TextSize = new System.Drawing.Size(81, 13);
            // 
            // lciLastName
            // 
            this.lciLastName.Control = this.teLastName;
            this.lciLastName.CustomizationFormText = "Soyadı";
            this.lciLastName.Location = new System.Drawing.Point(0, 24);
            this.lciLastName.Name = "lciLastName";
            this.lciLastName.Size = new System.Drawing.Size(305, 30);
            this.lciLastName.Text = "Soyadı";
            this.lciLastName.TextSize = new System.Drawing.Size(81, 13);
            // 
            // lcgTuslar
            // 
            this.lcgTuslar.CustomizationFormText = "Tuşlar";
            this.lcgTuslar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciClose,
            this.lciSelect,
            this.lciClean,
            this.lciSearch,
            this.lciNew});
            this.lcgTuslar.Location = new System.Drawing.Point(707, 0);
            this.lcgTuslar.Name = "lcgTuslar";
            this.lcgTuslar.Size = new System.Drawing.Size(227, 102);
            this.lcgTuslar.Text = "Tuşlar";
            this.lcgTuslar.TextVisible = false;
            // 
            // lciClose
            // 
            this.lciClose.Control = this.sbClose;
            this.lciClose.CustomizationFormText = "Çıkış";
            this.lciClose.Location = new System.Drawing.Point(100, 26);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(103, 52);
            this.lciClose.Text = "Çıkış";
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextToControlDistance = 0;
            this.lciClose.TextVisible = false;
            // 
            // lciSelect
            // 
            this.lciSelect.Control = this.sbSelect;
            this.lciSelect.CustomizationFormText = "Seç";
            this.lciSelect.Location = new System.Drawing.Point(0, 26);
            this.lciSelect.Name = "lciSelect";
            this.lciSelect.Size = new System.Drawing.Size(100, 26);
            this.lciSelect.Text = "Seç";
            this.lciSelect.TextSize = new System.Drawing.Size(0, 0);
            this.lciSelect.TextToControlDistance = 0;
            this.lciSelect.TextVisible = false;
            // 
            // lciClean
            // 
            this.lciClean.Control = this.sbClean;
            this.lciClean.CustomizationFormText = "Temizle";
            this.lciClean.Location = new System.Drawing.Point(100, 0);
            this.lciClean.Name = "lciClean";
            this.lciClean.Size = new System.Drawing.Size(103, 26);
            this.lciClean.Text = "Temizle";
            this.lciClean.TextSize = new System.Drawing.Size(0, 0);
            this.lciClean.TextToControlDistance = 0;
            this.lciClean.TextVisible = false;
            // 
            // lciSearch
            // 
            this.lciSearch.Control = this.sbSearch;
            this.lciSearch.CustomizationFormText = "Ara";
            this.lciSearch.Location = new System.Drawing.Point(0, 0);
            this.lciSearch.Name = "lciSearch";
            this.lciSearch.Size = new System.Drawing.Size(100, 26);
            this.lciSearch.Text = "Ara";
            this.lciSearch.TextSize = new System.Drawing.Size(0, 0);
            this.lciSearch.TextToControlDistance = 0;
            this.lciSearch.TextVisible = false;
            // 
            // lciNew
            // 
            this.lciNew.Control = this.sbNew;
            this.lciNew.CustomizationFormText = "lciYeni";
            this.lciNew.Location = new System.Drawing.Point(0, 52);
            this.lciNew.Name = "lciNew";
            this.lciNew.Size = new System.Drawing.Size(100, 26);
            this.lciNew.Text = "lciNew";
            this.lciNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciNew.TextToControlDistance = 0;
            this.lciNew.TextVisible = false;
            // 
            // lciHastaAdeti
            // 
            this.lciHastaAdeti.Control = this.lcHastaAdeti;
            this.lciHastaAdeti.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lciHastaAdeti.CustomizationFormText = "Patient Adeti";
            this.lciHastaAdeti.Location = new System.Drawing.Point(0, 601);
            this.lciHastaAdeti.Name = "lciHastaAdeti";
            this.lciHastaAdeti.Size = new System.Drawing.Size(934, 17);
            this.lciHastaAdeti.Text = "Patient Adeti";
            this.lciHastaAdeti.TextSize = new System.Drawing.Size(0, 0);
            this.lciHastaAdeti.TextToControlDistance = 0;
            this.lciHastaAdeti.TextVisible = false;
            // 
            // PersonelAraForm
            // 
            this.AcceptButton = this.sbSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbClose;
            this.ClientSize = new System.Drawing.Size(954, 638);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PersonelAraForm";
            this.Text = "Personel Arama Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonelArama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePersonnelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBulunanHastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAramaKriterleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpHastaNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTuslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHastaAdeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridPersonelArama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton sbSearch;
        private DevExpress.XtraEditors.TextEdit tePersonnelNo;
        private DevExpress.XtraEditors.TextEdit teTCId;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSayfa;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientNo;
        private DevExpress.XtraLayout.LayoutControlItem lciTCId;
        private DevExpress.XtraLayout.LayoutControlItem lciSearch;
        private DevExpress.XtraLayout.LayoutControlItem lciBulunanHastalar;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraLayout.LayoutControlGroup grpHastaNo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAramaKriterleri;
        private DevExpress.XtraLayout.LayoutControlItem lciFirstName;
        private DevExpress.XtraLayout.LayoutControlItem lciLastName;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbClean;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
        private DevExpress.XtraLayout.LayoutControlGroup grpSNR;
        private DevExpress.XtraLayout.LayoutControlGroup lcgTuslar;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraLayout.LayoutControlItem lciSelect;
        private DevExpress.XtraLayout.LayoutControlItem lciClean;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKimlikNo;
        private DevExpress.XtraEditors.LabelControl lcHastaAdeti;
        private DevExpress.XtraLayout.LayoutControlItem lciHastaAdeti;
        private DevExpress.XtraEditors.SimpleButton sbNew;
        private DevExpress.XtraLayout.LayoutControlItem lciNew;
        private DevExpress.XtraGrid.Columns.GridColumn colKNR;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}