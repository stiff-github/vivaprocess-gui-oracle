﻿using System;
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
    public partial class frmRptOtgruzNeed : DevExpress.XtraEditors.XtraForm
    {
        int fl_greed2 = 0;
        public frmRptOtgruzNeed()
        {
            InitializeComponent();
        }

        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            this.gridKuhni.Rows.Clear();
            gridKuhni.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Дата отгрузки";
            col0.Name = "prod_date_need";
            col0.ReadOnly = true;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "№№";
            col1.Name = "prod_id";
            col1.ReadOnly = true;
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "№ клиента";
            col2.Name = "prod_name";
            col2.ReadOnly = true;
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Клиент";
            col3.Name = "client_name";
            col3.ReadOnly = true;
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Описание";
            col4.Name = "prod_descr";
            col4.ReadOnly = true;
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Дата поступления";
            col5.Name = "prod_date_in";
            col5.ReadOnly = true;
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Цена";
            col6.Name = "prod_cena";
            col6.ReadOnly = true;
            col6.Visible = false;
            if (vivaprocess.Global.prava == "руководство" || vivaprocess.Global.prava == "adminko")
            {
                col6.Visible = true;
            }

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

                if (chkInWork.Checked == true & chkGotov.Checked == false & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where prod_date_otgruzka is null and prod_id in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where prod_date_otgruzka is null"
                        + " and (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where prod_date_otgruzka is not null or prod_id in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where prod_date_otgruzka is not null"
                        + " and (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where prod_date_otgruzka is null and prod_id not in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct nvl(prod_id,0) prod_id,nvl(prod_name,' ') prod_name,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yyyy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yyyy'),' ') prod_date_need,nvl(prod_cena,0) prod_cena"
                        + " FROM disp_kuhni where prod_date_otgruzka is not null or prod_id not in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_need between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_date_need,prod_id,client_name,prod_name";
                }

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
                    //cel0.Style.BackColor = Color.LightGray;
                    //string ssdata = (string)reader.GetString(5);
                    cel0.Value = DateTime.ParseExact((string)reader.GetString(5), "dd.M.yyyy", null); //(string)reader.GetString(5);
                    cel1.Value = (int)reader.GetDecimal(0);
                    cel2.Value = (string)reader.GetString(1);
                    cel3.Value = (string)reader.GetString(3);
                    cel4.Value = (string)reader.GetString(2);
                    if (reader.GetString(4).Length > 2) { 
                        cel5.Value = DateTime.ParseExact((string)reader.GetString(4), "dd.M.yyyy", null);
                    }
                    cel6.Value = (string)reader.GetDecimal(6).ToString();
                    row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4, cel5, cel6);
                    this.gridKuhni.Rows.Add(row);
                }
                //gridKuhni.Columns[0].Frozen = true;
                gridKuhni.Columns[0].DefaultCellStyle.Format = "d";
                gridKuhni.Columns[5].DefaultCellStyle.Format = "d";
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

        private void frmRptOtgruzNeed_Load(object sender, EventArgs e)
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
                if (vivaprocess.Global.prava == "руководство" || vivaprocess.Global.prava == "adminko")
                {
                    rptOtgruzNeedCena rptOtgruzNeedCenaF = new rptOtgruzNeedCena();
                    int i = 0;
                    string rptFilter = "[PROD_ID] In (" + gridKuhni[1, 0].Value.ToString();
                    for (i = 1; i <= gridKuhni.RowCount - 1; i++)
                    {
                        rptFilter = rptFilter + "," + gridKuhni[1, i].Value.ToString();
                    }
                    rptOtgruzNeedCenaF.FilterString = rptFilter + ")"; //"[PROD_ID] In (1, 2)"
                    rptOtgruzNeedCenaF.ShowPreview();
                }
                else
                {
                    rptOtgruzNeed rptOtgruzNeedF = new rptOtgruzNeed();
                    int i = 0;
                    string rptFilter = "[PROD_ID] In (" + gridKuhni[1, 0].Value.ToString();
                    for (i = 1; i <= gridKuhni.RowCount - 1; i++)
                    {
                        rptFilter = rptFilter + "," + gridKuhni[1, i].Value.ToString();
                    }
                    rptOtgruzNeedF.FilterString = rptFilter + ")"; //"[PROD_ID] In (1, 2)"
                    rptOtgruzNeedF.ShowPreview();
                }
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }


    }
}