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
    public partial class frmRptReklamac : DevExpress.XtraEditors.XtraForm
    {
        int fl_greed2 = 0;
        public frmRptReklamac()
        {
            InitializeComponent();
        }

        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            this.gridKuhni.Rows.Clear();
            gridKuhni.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Дата рекламации";
            col0.Name = "DATE_IN";
            col0.ReadOnly = true;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Клиент";
            col1.Name = "client_name";
            col1.ReadOnly = true;
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Рекламация";
            col2.Name = "REKLAMAC_NAME";
            col2.ReadOnly = true;
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Описание";
            col3.Name = "REKLAMAC_DESCR";
            col3.ReadOnly = true;
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "№ заказа";
            col4.Name = "prod_id";
            col4.ReadOnly = true;
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Стоимость";
            col5.Name = "STOIM";
            col5.ReadOnly = true;
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Дата отгрузки";
            col6.Name = "DATE_OUT";
            col6.ReadOnly = true;
            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "ITEM_ID";
            col7.Name = "ITEM_ID";
            col7.ReadOnly = true;
            col7.Visible = false;
            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Виновник";
            col8.Name = "REKLAMAC_PERS";
            col8.ReadOnly = true;

            if (fl_greed2 == 0)
            {
                this.gridKuhni.Columns.Add(col0);
                this.gridKuhni.Columns.Add(col1);
                this.gridKuhni.Columns.Add(col2);
                this.gridKuhni.Columns.Add(col3);
                this.gridKuhni.Columns.Add(col8);
                this.gridKuhni.Columns.Add(col4);
                this.gridKuhni.Columns.Add(col5);
                this.gridKuhni.Columns.Add(col6);
                this.gridKuhni.Columns.Add(col7);
            }
            fl_greed2 = 1;
            string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con1 = new OracleConnection(constr);
            try
            {
                con1.Open();
                OracleCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (chkInWork.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select item_id,nvl(prod_id,0) prod_id,nvl(REKLAMAC_NAME,' ') REKLAMAC_NAME,nvl(REKLAMAC_DESCR,' ') REKLAMAC_DESCR,nvl(client_name,' ') client_name,nvl(to_char(DATE_IN,'dd.mm.yyyy'),' ') DATE_IN,"
                        + " nvl(to_char(DATE_OUT,'dd.mm.yyyy'),' ') DATE_OUT,nvl(STOIM,0) STOIM,nvl(REKLAMAC_PERS,' ') REKLAMAC_PERS"
                        + " FROM REKLAMAC where DATE_OUT is null"
                        + " and (DATE_IN between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by DATE_IN,prod_id,client_name,REKLAMAC_NAME";
                }
                else if (chkInWork.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select item_id,nvl(prod_id,0) prod_id,nvl(REKLAMAC_NAME,' ') REKLAMAC_NAME,nvl(REKLAMAC_DESCR,' ') REKLAMAC_DESCR,nvl(client_name,' ') client_name,nvl(to_char(DATE_IN,'dd.mm.yyyy'),' ') DATE_IN,"
                        + " nvl(to_char(DATE_OUT,'dd.mm.yyyy'),' ') DATE_OUT,nvl(STOIM,0) STOIM,nvl(REKLAMAC_PERS,' ') REKLAMAC_PERS"
                        + " FROM REKLAMAC where"
                        + " (DATE_IN between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by DATE_IN,prod_id,client_name,REKLAMAC_NAME";
                }
                else if (chkInWork.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select item_id,nvl(prod_id,0) prod_id,nvl(REKLAMAC_NAME,' ') REKLAMAC_NAME,nvl(REKLAMAC_DESCR,' ') REKLAMAC_DESCR,nvl(client_name,' ') client_name,nvl(to_char(DATE_IN,'dd.mm.yyyy'),' ') DATE_IN,"
                        + " nvl(to_char(DATE_OUT,'dd.mm.yyyy'),' ') DATE_OUT,nvl(STOIM,0) STOIM,nvl(REKLAMAC_PERS,' ') REKLAMAC_PERS"
                        + " FROM REKLAMAC where prod_date_otgruzka is not null"
                        + " and (DATE_IN between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by DATE_IN,prod_id,client_name,REKLAMAC_NAME";
                }

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewCell cel0 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel1 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel2 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel3 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel8 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel4 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel5 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel6 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel7 = new DataGridViewTextBoxCell();
                    DataGridViewRow row = new DataGridViewRow();
                    //cel0.Style.BackColor = Color.LightGray;
                    cel0.Value = DateTime.ParseExact((string)reader.GetString(5), "dd.M.yyyy", null);  //(string)reader.GetString(5);
                    cel1.Value = (string)reader.GetString(4); //(int)reader.GetDecimal(0);
                    cel2.Value = (string)reader.GetString(2);
                    cel3.Value = (string)reader.GetString(3);
                    cel8.Value = (string)reader.GetString(8);
                    cel4.Value = (string)reader.GetDecimal(1).ToString().Trim();
                    cel5.Value = (string)reader.GetDecimal(7).ToString().Trim();
                    if (reader.GetString(6).Length>2)
                    { 
                        cel6.Value = DateTime.ParseExact((string)reader.GetString(6), "dd.M.yyyy", null);
                    }
                    cel7.Value = (string)reader.GetDecimal(0).ToString().Trim();
                    row.Cells.AddRange(cel0, cel1, cel2, cel3, cel8, cel4, cel5, cel6, cel7);
                    this.gridKuhni.Rows.Add(row);
                }
                gridKuhni.Columns[0].DefaultCellStyle.Format = "d";
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void frmRptReklamac_Load(object sender, EventArgs e)
        {
            dateEnd.Text = DateTime.Now.ToString("dd.MM.yyyy");
            dateStart.Text = "01." + DateTime.Now.ToString("MM.yyyy");
            vivaprocess.Global.rptStart = dateStart.Text;
            vivaprocess.Global.rptEnd = dateEnd.Text;
            refresh_kuhni();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            vivaprocess.Global.rptStart = dateStart.Text;
            vivaprocess.Global.rptEnd = dateEnd.Text;
            refresh_kuhni();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (gridKuhni.RowCount > 0)
            {
                rptReklamacii rptReklamaciiF = new rptReklamacii();
                int i = 0;
                string rptFilter = "[item_id] In (" + gridKuhni[8, 0].Value.ToString();
                for (i = 1; i <= gridKuhni.RowCount - 1; i++)
                {
                    rptFilter = rptFilter + "," + gridKuhni[8, i].Value.ToString();
                }
                rptReklamaciiF.FilterString = rptFilter + ")"; //"[PROD_ID] In (1, 2)"
                rptReklamaciiF.ShowPreview();
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }


    }
}