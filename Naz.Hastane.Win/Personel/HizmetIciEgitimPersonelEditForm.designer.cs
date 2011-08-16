﻿using Naz.Hastane.Data.Entities;
namespace Naz.Hastane.Win.MDIChildForms
{
    partial class HizmetIciEgitimPersonelEditForm
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
            this.sbSaveAndNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.sbSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.meAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAciklama = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveAndClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciPersonel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveAndNew = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndNew)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbSaveAndNew);
            this.layoutControl1.Controls.Add(this.cmbPersonel);
            this.layoutControl1.Controls.Add(this.sbSaveAndClose);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.meAciklama);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(395, 233);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbSaveAndNew
            // 
            this.sbSaveAndNew.Location = new System.Drawing.Point(241, 53);
            this.sbSaveAndNew.Name = "sbSaveAndNew";
            this.sbSaveAndNew.Size = new System.Drawing.Size(142, 22);
            this.sbSaveAndNew.StyleController = this.layoutControl1;
            this.sbSaveAndNew.TabIndex = 13;
            this.sbSaveAndNew.Text = "Sakla ve Yeni Kayıt";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(57, 12);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(180, 21);
            this.cmbPersonel.TabIndex = 10;
            // 
            // sbSaveAndClose
            // 
            this.sbSaveAndClose.Location = new System.Drawing.Point(241, 99);
            this.sbSaveAndClose.Name = "sbSaveAndClose";
            this.sbSaveAndClose.Size = new System.Drawing.Size(142, 22);
            this.sbSaveAndClose.StyleController = this.layoutControl1;
            this.sbSaveAndClose.TabIndex = 9;
            this.sbSaveAndClose.Text = "Sakla ve Kapat";
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(241, 199);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(142, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 6;
            this.sbCancel.Text = "Vazgeç";
            // 
            // meAciklama
            // 
            this.meAciklama.Location = new System.Drawing.Point(57, 37);
            this.meAciklama.Name = "meAciklama";
            this.meAciklama.Size = new System.Drawing.Size(180, 184);
            this.meAciklama.StyleController = this.layoutControl1;
            this.meAciklama.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAciklama,
            this.lciSaveAndClose,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciPersonel,
            this.lciCancel,
            this.lciSaveAndNew});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(395, 233);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciAciklama
            // 
            this.lciAciklama.Control = this.meAciklama;
            this.lciAciklama.CustomizationFormText = "Açıklama";
            this.lciAciklama.Location = new System.Drawing.Point(0, 25);
            this.lciAciklama.Name = "lciAciklama";
            this.lciAciklama.Size = new System.Drawing.Size(229, 188);
            this.lciAciklama.Text = "Açıklama";
            this.lciAciklama.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciSaveAndClose
            // 
            this.lciSaveAndClose.Control = this.sbSaveAndClose;
            this.lciSaveAndClose.CustomizationFormText = "layoutControlItem6";
            this.lciSaveAndClose.Location = new System.Drawing.Point(229, 87);
            this.lciSaveAndClose.Name = "lciSaveAndClose";
            this.lciSaveAndClose.Size = new System.Drawing.Size(146, 26);
            this.lciSaveAndClose.Text = "lciSaveAndClose";
            this.lciSaveAndClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveAndClose.TextToControlDistance = 0;
            this.lciSaveAndClose.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(229, 67);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(146, 20);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(229, 113);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(146, 74);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(229, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(146, 41);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciPersonel
            // 
            this.lciPersonel.Control = this.cmbPersonel;
            this.lciPersonel.CustomizationFormText = "Personel";
            this.lciPersonel.Location = new System.Drawing.Point(0, 0);
            this.lciPersonel.Name = "lciPersonel";
            this.lciPersonel.Size = new System.Drawing.Size(229, 25);
            this.lciPersonel.Text = "Personel";
            this.lciPersonel.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.CustomizationFormText = "layoutControlItem3";
            this.lciCancel.Location = new System.Drawing.Point(229, 187);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(146, 26);
            this.lciCancel.Text = "lciCancel";
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextToControlDistance = 0;
            this.lciCancel.TextVisible = false;
            // 
            // lciSaveAndNew
            // 
            this.lciSaveAndNew.Control = this.sbSaveAndNew;
            this.lciSaveAndNew.CustomizationFormText = "lciSaveAndNew";
            this.lciSaveAndNew.Location = new System.Drawing.Point(229, 41);
            this.lciSaveAndNew.Name = "lciSaveAndNew";
            this.lciSaveAndNew.Size = new System.Drawing.Size(146, 26);
            this.lciSaveAndNew.Text = "lciSaveAndNew";
            this.lciSaveAndNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveAndNew.TextToControlDistance = 0;
            this.lciSaveAndNew.TextVisible = false;
            // 
            // HizmetIciEgitimPersonelEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 233);
            this.Controls.Add(this.layoutControl1);
            this.Name = "HizmetIciEgitimPersonelEditForm";
            this.Text = "Personel Eğitim Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbSaveAndClose;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciAciklama;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveAndClose;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private DevExpress.XtraLayout.LayoutControlItem lciPersonel;
        private DevExpress.XtraEditors.MemoEdit meAciklama;
        private DevExpress.XtraEditors.SimpleButton sbSaveAndNew;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveAndNew;
    }
}