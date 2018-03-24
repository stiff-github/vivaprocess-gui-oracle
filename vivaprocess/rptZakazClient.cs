using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace vivaprocess
{
    public partial class rptZakazClient : DevExpress.XtraReports.UI.XtraReport
    {
        public rptZakazClient()
        {
            InitializeComponent();
            lblHeader.Text = "Заказы клиента " + vivaprocess.Global.rptClient + " за период с " + vivaprocess.Global.rptStart + " по " + vivaprocess.Global.rptEnd;
        }

    }
}
