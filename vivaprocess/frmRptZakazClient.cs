using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;

namespace vivaprocess
{
    public partial class frmRptZakazClient : DevExpress.XtraEditors.XtraForm
    {
        int fl_greed2 = 0;
        public frmRptZakazClient()
        {
            InitializeComponent();
            sqlDataClients.Fill();
        }

        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (lookUpClients.ItemIndex>-1)
            { 
                this.gridKuhni.Rows.Clear();
                gridKuhni.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "№№";
                col0.Name = "prod_id";
                col0.ReadOnly = true;
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "№ клиента";
                col1.Name = "prod_name";
                col1.ReadOnly = true;
                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "Дата поступления";
                col2.Name = "prod_date_in";
                col2.ReadOnly = true;
                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Описание";
                col3.Name = "prod_descr";
                col3.ReadOnly = true;
                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Стоимость";
                col4.Name = "prod_cena";
                col4.ReadOnly = true;
                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
                col5.HeaderText = "План отгрузки";
                col5.Name = "prod_date_need";
                col5.ReadOnly = true;
                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
                col6.HeaderText = "Факт отгрузки";
                col6.Name = "prod_date_otgruzka";
                col6.ReadOnly = true;

                if (fl_greed2 == 0)
                {
                    this.gridKuhni.Columns.Add(col0);
                    this.gridKuhni.Columns.Add(col1);
                    this.gridKuhni.Columns.Add(col2);
                    this.gridKuhni.Columns.Add(col3);
                    this.gridKuhni.Columns.Add(col4);
                    this.gridKuhni.Columns.Add(col5);
                    this.gridKuhni.Columns.Add(col6);
                }
                fl_greed2 = 1;
                string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con1 = new OracleConnection(constr);
                try
                {
                    con1.Open();
                    OracleCommand cmd = con1.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from(select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,nvl(prod_descr,' ') prod_descr,"
                            + " nvl(prod_cena,0) prod_cena,nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(to_char(prod_date_otgruzka,'dd.mm.yyyy'),' ') prod_date_otgruzka"
                            + " FROM disp_kuhni where client_name='" + lookUpClients.Properties.GetDataSourceValue("CLIENT_NAME", lookUpClients.ItemIndex).ToString().Trim() + "'"
                            + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by prod_id,prod_date_in,prod_name)"
                            + " union all select 0,' ',' ','Итого:',sum(prod_cena) prod_cena,' ',' '"
                            + " from (select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,nvl(prod_descr,' ') prod_descr,"
                            + " nvl(prod_cena,0) prod_cena,nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(to_char(prod_date_otgruzka,'dd.mm.yyyy'),' ') prod_date_otgruzka"
                            + " FROM disp_kuhni where client_name='" + lookUpClients.Properties.GetDataSourceValue("CLIENT_NAME", lookUpClients.ItemIndex).ToString().Trim() + "'"
                            + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by prod_id,prod_date_in,prod_name)";

                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataGridViewCell cel0 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel1 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel2 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel3 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel4 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel5 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel6 = new DataGridViewTextBoxCell();
                        DataGridViewRow row = new DataGridViewRow();
                        cel0.Value = (string)reader.GetDecimal(0).ToString();
                        cel1.Value = (string)reader.GetString(1);
                        if (reader.GetString(2).Length > 2)
                        {
                            cel2.Value = DateTime.ParseExact((string)reader.GetString(2), "dd.M.yyyy", null);
                        }
                        cel3.Value = (string)reader.GetString(3);
                        cel4.Value = (string)reader.GetDecimal(4).ToString();
                        if (reader.GetString(5).Length > 2)
                        {
                            cel5.Value = DateTime.ParseExact((string)reader.GetString(5), "dd.M.yyyy", null);
                        }
                        if (reader.GetString(6).Length > 2)
                        {
                            cel6.Value = DateTime.ParseExact((string)reader.GetString(6), "dd.M.yyyy", null);
                        }
                        row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4, cel5, cel6);
                        this.gridKuhni.Rows.Add(row);
                    }
                    gridKuhni.Columns[2].DefaultCellStyle.Format = "d";
                    gridKuhni.Columns[5].DefaultCellStyle.Format = "d";
                    gridKuhni.Columns[6].DefaultCellStyle.Format = "d";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con1.Dispose();
                }
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void frmRptZakazClient_Load(object sender, EventArgs e)
        {
            dateEnd.Text = DateTime.Now.ToString("dd.MM.yyyy");
            dateStart.Text = "01." + DateTime.Now.ToString("MM.yyyy");
            vivaprocess.Global.rptStart = dateStart.Text;
            vivaprocess.Global.rptEnd = dateEnd.Text;
            //vivaprocess.Global.rptClient = lookUpClients.Properties.GetDataSourceValue("CLIENT_NAME", lookUpClients.ItemIndex).ToString().Trim();
            //refresh_kuhni();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            vivaprocess.Global.rptStart = dateStart.Text;
            vivaprocess.Global.rptEnd = dateEnd.Text;
            vivaprocess.Global.rptClient = lookUpClients.Properties.GetDataSourceValue("CLIENT_NAME", lookUpClients.ItemIndex).ToString().Trim();
            refresh_kuhni();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (gridKuhni.RowCount > 0)
            {
                rptZakazClient rptZakazClientF = new rptZakazClient();
                int i = 0;
                string rptFilter = "[PROD_ID] In (" + gridKuhni[0, 0].Value.ToString();
                for (i = 1; i <= gridKuhni.RowCount - 1; i++)
                {
                    rptFilter = rptFilter + "," + gridKuhni[0, i].Value.ToString();
                }
                rptZakazClientF.FilterString = rptFilter + ")";
                rptZakazClientF.ShowPreview();
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void BindSourceClients_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}