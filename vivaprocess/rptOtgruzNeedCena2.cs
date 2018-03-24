using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace vivaprocess
{
    public partial class rptOtgruzNeedCena2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOtgruzNeedCena2()
        {
            InitializeComponent();
            lblHeader.Text = "План на отгрузку за период с " + vivaprocess.Global.rptStart + " по " + vivaprocess.Global.rptEnd;
        }

    }
}
