using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;

namespace vivaprocess
{
    public partial class frmSlegenMaterial : Form
    {
        int fl_greed = 0;
        int fl_greed2 = 0;
        public frmSlegenMaterial()
        {
            InitializeComponent();
        }

        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            int perGreen = 0;
            int perYellow = 0;
            int perRed = 0;
            int bColor = 0;
            string tmpLen0, tmpLen;

            this.gridKuhni.Rows.Clear();
            gridKuhni.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "№№";
            col0.Name = "prod_id";
            col0.ReadOnly = true;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Клиент";
            col1.Name = "client_name";
            col1.ReadOnly = true;
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Описание";
            col2.Name = "prod_descr";
            col2.ReadOnly = true;
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Дата поступления";
            col3.Name = "prod_date_in";
            col3.ReadOnly = true;
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Дата отгрузки";
            col4.Name = "prod_date_need";
            col4.ReadOnly = true;
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Передано техотдел";
            col5.Name = "date_tehnol";
            col5.ReadOnly = true;
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Произв-во план";
            col6.Name = "proizvod_plan";
            col6.ReadOnly = true;
            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Произв-во факт";
            col7.Name = "proizvod_fakt";
            col7.ReadOnly = true;
            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Краска план";
            col8.Name = "kraska_plan";
            col8.ReadOnly = true;
            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.HeaderText = "Краска факт";
            col9.Name = "kraska_fakt";
            col9.ReadOnly = true;
            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            col10.HeaderText = "Примеч. произв-ва";
            col10.Name = "proizvod_descr";
            col10.ReadOnly = true;
            DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
            col11.HeaderText = "ОТК план";
            col11.Name = "otk_plan";
            col11.ReadOnly = true;
            DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
            col12.HeaderText = "ОТК факт";
            col12.Name = "otk_fakt";
            col12.ReadOnly = true;
            DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
            col13.HeaderText = "item";
            col13.Name = "item_id";
            col13.ReadOnly = true;
            col13.Visible = false;

            if (fl_greed2 == 0)
            {
                this.gridKuhni.Columns.Add(col0);
                this.gridKuhni.Columns.Add(col1);
                this.gridKuhni.Columns.Add(col2);
                this.gridKuhni.Columns.Add(col3);
                this.gridKuhni.Columns.Add(col4);
                this.gridKuhni.Columns.Add(col5);
                this.gridKuhni.Columns.Add(col6);
                this.gridKuhni.Columns.Add(col7);
                this.gridKuhni.Columns.Add(col8);
                this.gridKuhni.Columns.Add(col9);
                this.gridKuhni.Columns.Add(col10);
                this.gridKuhni.Columns.Add(col11);
                this.gridKuhni.Columns.Add(col12);
                this.gridKuhni.Columns.Add(col13);
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
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where prod_date_otgruzka is null and prod_id in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy'))"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where prod_date_otgruzka is null  and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy'))"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where (prod_date_otgruzka is not null or prod_id in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null))"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where prod_date_otgruzka is not null  and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy'))"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where prod_date_otgruzka is null and prod_id not in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " ,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt"
                        + " ,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt, nvl(proizvod_descr,' ') proizvod_descr"
                        + " ,nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt, mat_name, nvl(mat_descr,' ') mat_descr, item_id"
                        + " ,(proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff,(otk_plan-trunc(sysdate)) otk_plan_diff"
                        + " FROM disp_kuhni where (prod_date_otgruzka is not null or prod_id not in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null))"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and mat_name='" + cmbMaterial.Text + "' and mat_descr<>'нет'"
                        + " order by prod_id,prod_in,client_name,prod_name";
                }
                else
                {
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    return;
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
                    DataGridViewCell cel7 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel8 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel9 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel10 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel11 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel12 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel13 = new DataGridViewTextBoxCell();
                    DataGridViewRow row = new DataGridViewRow();
                    cel0.Style.BackColor = Color.LightGray;
                    cel0.Value = (int)reader.GetDecimal(1);
                    cel1.Value = (string)reader.GetString(3);
                    cel2.Value = (string)reader.GetString(reader.GetOrdinal("prod_descr"));
                    if (reader.GetString(4).Length > 2)
                    {
                        cel3.Value = DateTime.ParseExact((string)reader.GetString(4), "dd.M.yy", null);
                    }
                    if (reader.GetString(5).Length > 2)
                    {
                        cel4.Value = DateTime.ParseExact((string)reader.GetString(5), "dd.M.yy", null);
                    }
                    if (reader.GetString(6).Length > 2)
                    {
                        cel5.Value = DateTime.ParseExact((string)reader.GetString(6), "dd.M.yy", null);
                    }

                    tmpLen0 = (string)reader.GetString(reader.GetOrdinal("proizvod_plan"));
                    cel6.Value = tmpLen0;
                    tmpLen = (string)reader.GetString(reader.GetOrdinal("proizvod_fakt"));
                    if (tmpLen.Length < 2 & tmpLen0.Length > 1)
                    {
                        bColor = (int)reader.GetDecimal(reader.GetOrdinal("proizvod_plan_diff"));
                        if (bColor <= perGreen & bColor > perYellow)
                        {
                            cel6.Style.BackColor = Color.LimeGreen;
                        }
                        else if (bColor <= perYellow & bColor > perRed)
                        {
                            cel6.Style.BackColor = Color.Yellow;
                        }
                        else if (bColor <= perRed)
                        {
                            cel6.Style.BackColor = Color.Red;
                        }
                    }
                    cel7.Value = tmpLen;

                    tmpLen0 = (string)reader.GetString(reader.GetOrdinal("kraska_plan"));
                    cel8.Value = tmpLen0;
                    tmpLen = (string)reader.GetString(reader.GetOrdinal("kraska_fakt"));
                    if (tmpLen.Length < 2 & tmpLen0.Length > 1)
                    {
                        bColor = (int)reader.GetDecimal(reader.GetOrdinal("kraska_plan_diff"));
                        if (bColor <= perGreen & bColor > perYellow)
                        {
                            cel8.Style.BackColor = Color.LimeGreen;
                        }
                        else if (bColor <= perYellow & bColor > perRed)
                        {
                            cel8.Style.BackColor = Color.Yellow;
                        }
                        else if (bColor <= perRed)
                        {
                            cel8.Style.BackColor = Color.Red;
                        }
                    }
                    cel9.Value = tmpLen;

                    cel10.Value = (string)reader.GetString(reader.GetOrdinal("proizvod_descr"));

                    tmpLen0 = (string)reader.GetString(reader.GetOrdinal("otk_plan"));
                    cel11.Value = tmpLen0;
                    tmpLen = (string)reader.GetString(reader.GetOrdinal("otk_fakt"));
                    if (tmpLen.Length < 2 & tmpLen0.Length > 1)
                    {
                        bColor = (int)reader.GetDecimal(reader.GetOrdinal("otk_plan_diff"));
                        if (bColor <= perGreen & bColor > perYellow)
                        {
                            cel11.Style.BackColor = Color.LimeGreen;
                        }
                        else if (bColor <= perYellow & bColor > perRed)
                        {
                            cel11.Style.BackColor = Color.Yellow;
                        }
                        else if (bColor <= perRed)
                        {
                            cel11.Style.BackColor = Color.Red;
                        }
                    }
                    cel12.Value = tmpLen;
                    cel13.Value = (int)reader.GetDecimal(reader.GetOrdinal("item_id"));

                    row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4, cel5, cel6, cel7, cel8, cel9, cel10, cel11, cel12, cel13);
                    this.gridKuhni.Rows.Add(row);
                }
                gridKuhni.Columns[0].Frozen = true;
                gridKuhni.Columns[3].DefaultCellStyle.Format = "d";
                gridKuhni.Columns[4].DefaultCellStyle.Format = "d";
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            vivaprocess.Global.rptStart = dateStart.Text;
            vivaprocess.Global.rptEnd = dateEnd.Text;
            vivaprocess.Global.rptMaterial = cmbMaterial.Text;
            refresh_kuhni();
        }

        private void frmSlegenMaterial_Load(object sender, EventArgs e)
        {
            dateEnd.Text = DateTime.Now.ToString("dd.MM.yyyy");
            dateStart.Text = "01." + DateTime.Now.ToString("MM.yyyy");
            vivaprocess.Global.rptStart = dateStart.Text;
            vivaprocess.Global.rptEnd = dateEnd.Text;
            cmbMaterial.Items.Clear();
            cmbMaterial.Items.Add("дсп");
            cmbMaterial.Items.Add("фасады");
            cmbMaterial.Items.Add("дсп краска");
            cmbMaterial.Items.Add("двп");
            cmbMaterial.Items.Add("фурнитура");
            cmbMaterial.Items.Add("витражи");
            cmbMaterial.Items.Add("столешница");
            cmbMaterial.Items.Add("скинали");
            cmbMaterial.Items.Add("дополнит.");
            cmbMaterial.Text = "фасады";
            vivaprocess.Global.rptMaterial = cmbMaterial.Text;
            refresh_kuhni();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (gridKuhni.RowCount > 0)
            {
                rptKuhniMat rptKuhniMatF = new rptKuhniMat();
                vivaprocess.Global.rptStart = dateStart.Text;
                vivaprocess.Global.rptEnd = dateEnd.Text;
                vivaprocess.Global.rptMaterial = cmbMaterial.Text;
                int i = 0;
                string rptFilter = "[ITEM_ID] In (" + gridKuhni[13, 0].Value.ToString();
                for (i = 1; i <= gridKuhni.RowCount - 1; i++)
                {
                    rptFilter = rptFilter + "," + gridKuhni[13, i].Value.ToString();
                }
                rptKuhniMatF.FilterString = rptFilter + ")";
                rptKuhniMatF.ShowPreview();
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
