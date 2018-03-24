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
    public partial class rptKuhni1 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKuhni1()
        {
            InitializeComponent();
            lblHeader.Text = "Заказы за период с " + vivaprocess.Global.rptStart + " по " + vivaprocess.Global.rptEnd;
            //sqlDataSource1.CustomFilterExpression = "where (prod_date_in between to_date('01.02.2017','dd.mm.yyyy') and to_date('20.02.2017','dd.mm.yyyy'))";
            //sqlDataSource1.ActiveFilterString = "[prod_date_in]Between('" + vivaprocess.Global.rptStart + "','" + vivaprocess.Global.rptEnd + "')";

            /*OracleConnectionParameters connectionParameters = new OracleConnectionParameters(vivaprocess.Global.ora_serv, "kuhni_modul", "kuhni");
            SqlDataSource ds = new SqlDataSource(connectionParameters);
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = "customQuery1";
            query.Sql = "select prod_id,prod_name,prod_id||'/'||prod_name as prod,nvl(client_name,' ') client_name,nvl(prod_descr,' ') prod_descr,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                    + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,mat_name mat_name, nvl(mat_descr,' ') mat_descr,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,"
                    + " nvl(tehnolog,' ') tehnolog,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt,"
                    + " nvl(proizvod_descr,' ') proizvod_descr,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt,"
                    + " nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt,nvl(to_char(kontrol_sborka_plan,'dd.mm.yy'),' ') сборка_план,"
                    + " nvl(to_char(kontrol_sborka_fakt,'dd.mm.yy'),' ') сборка_факт,nvl(otk_descr,' ') примеч_отк,nvl(to_char(sklad_gotov_plan,'dd.mm.yy'),' ') скл_гот_план,"
                    + " nvl(to_char(sklad_gotov_fakt,'dd.mm.yy'),' ') скл_гот_факт,nvl(to_char(snabgen_zayavka,'dd.mm.yy'),' ') снабж_заявка,"
                    + " nvl(snabgen_info,' ') обработка_снабж,nvl(material_na_sklad,' ') матер_склад,nvl(prod_cena,0) цена,"
                    + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') отгруз_факт,nvl(prod_descr_otgruzka,' ') примечания"
                    + " FROM disp_kuhni where (prod_date_in between to_date('01.02.2017','dd.mm.yyyy') and to_date('20.02.2017','dd.mm.yyyy')) order by prod_date_in,prod_id,item_id";

            ds.Queries.Add(query);
            ds.Fill();
            this.DataSource = ds;
            this.DataMember = "customQuery1";
            /*lblNN.DataBindings.Add("Text", null, "customQuery1.prod_id||'/'||customQuery1.prod_name");*/
        }

    }
}
