﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace App
{
    public partial class Xrpt_SVDKLTC : DevExpress.XtraReports.UI.XtraReport
    {
       

        public Xrpt_SVDKLTC(string nienKhoa, int hocKy, string monHoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = monHoc;
            this.sqlDataSource1.Fill();

        }

    }
}
