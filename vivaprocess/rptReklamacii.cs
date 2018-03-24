using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace vivaprocess
{
    public partial class rptReklamacii : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReklamacii()
        {
            InitializeComponent();
            lblHeader.Text = "Рекламации за период с " + vivaprocess.Global.rptStart + " по " + vivaprocess.Global.rptEnd;
        }

    }
}
