﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.LookUp;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectPolyclinicForm : MDIChildForm
    {
        private Doctor _Doctor = null;
        public Doctor Doctor { get { return _Doctor; } }

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        public SelectPolyclinicForm()
        {
            InitializeComponent();

            var doctors = LookUpServices.GetSGKDoctors();
            gcView.DataSource = doctors;
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            OnSelectionMade();
        }

        private void gvPolyclinics_DoubleClick(object sender, EventArgs e)
        {
            OnSelectionMade();
        }

        private void OnSelectionMade()
        {
            if (this.gvPolyclinics.GetFocusedRow() != null)
            {
                _Doctor = (Doctor)this.gvPolyclinics.GetFocusedRow();
                _IsSelected = (_Doctor != null);
                if (_IsSelected) this.Close();
            }
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}