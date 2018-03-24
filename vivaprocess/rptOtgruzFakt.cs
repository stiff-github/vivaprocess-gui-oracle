using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace vivaprocess
{
    public partial class rptOtgruzFakt : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOtgruzFakt()
        {
            InitializeComponent();
            lblHeader.Text = "Отгрузка за период с " + vivaprocess.Global.rptStart + " по " + vivaprocess.Global.rptEnd;
        }

    }
}
