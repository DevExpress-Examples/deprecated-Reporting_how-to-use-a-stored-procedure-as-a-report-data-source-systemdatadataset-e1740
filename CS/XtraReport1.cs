using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using RepStoredProc.NorthwindDataSetTableAdapters;

namespace RepStoredProc {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            custOrdersDetailTableAdapter.Fill((this.DataSource as NorthwindDataSet).CustOrdersDetail, Convert.ToInt32(Parameters["OrderId"].Value));
        }
    }
}
