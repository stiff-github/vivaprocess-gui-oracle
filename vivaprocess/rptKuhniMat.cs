using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Data.Filtering;

namespace vivaprocess
{
    public partial class rptKuhniMat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKuhniMat()
        {
            InitializeComponent();
            lblHeader.Text = "Заказы по материалу " + vivaprocess.Global.rptMaterial + " за период с " + vivaprocess.Global.rptStart + " по " + vivaprocess.Global.rptEnd;
        }

    }
}
