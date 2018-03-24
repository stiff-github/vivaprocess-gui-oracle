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
    public partial class frmInfo : Form
    {
        int fl_greed = 0;
        int fl_greed2 = 0;
        public frmInfo()
        {
            InitializeComponent();
            //sqlDataAll.Fill();
        }

        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

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
            col2.HeaderText = "Клиент";
            col2.Name = "client_name";
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Описание";
            col3.Name = "prod_descr";
            col3.ReadOnly = true;
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Дата поступления";
            col4.Name = "prod_date_in";
            col4.ReadOnly = true;
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Дата отгрузки";
            col5.Name = "prod_date_need";
            col5.ReadOnly = true;
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Передано техотдел";
            col6.Name = "date_tehnol";
            col6.ReadOnly = true;
            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Исполнитель";
            col7.Name = "tehnolog";
            col7.ReadOnly = true;
            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Цена";
            col8.Name = "prod_cena";
            col8.ReadOnly = true;
            if (vivaprocess.Global.prava == "технолог" || vivaprocess.Global.prava == "цех" || vivaprocess.Global.prava == "склад продукции" || vivaprocess.Global.prava == "снабжение")
            {
                col8.Visible = false;
            }
            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.HeaderText = "Факт дата отгрузки";
            col9.Name = "prod_date_otgruzka";
            col9.ReadOnly = true;
            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            col10.HeaderText = "Примечания по проекту";
            col10.Name = "prod_descr_otgruzka";
            col10.ReadOnly = true;

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
            }
            fl_greed2 = 1;
            string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con1 = new OracleConnection(constr);
            try
            {
                con1.Open();
                OracleCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (chkInWork.Checked==true & chkGotov.Checked==false & chkOtgrugen.Checked==false) 
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where prod_date_otgruzka is null and prod_id in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where prod_date_otgruzka is null  and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == true & chkGotov.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where (prod_date_otgruzka is not null or prod_id in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null))"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == false & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where prod_date_otgruzka is not null  and (vse=1 or vse=" + vivaprocess.Global.vse + ")"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == true & chkOtgrugen.Checked == false)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where prod_date_otgruzka is null and prod_id not in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null)"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_id,prod_in,client_name,prod_name";
                }
                else if (chkInWork.Checked == false & chkGotov.Checked == true & chkOtgrugen.Checked == true)
                {
                    cmd.CommandText = "select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,nvl(tehnolog,' ') tehnolog,nvl(prod_cena,0) prod_cena,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') prod_date_otgruzka,nvl(prod_descr_otgruzka,' ') prod_descr_otgruzka,nvl(status,' ') status, prod_date_in prod_in"
                        + " FROM disp_kuhni where (prod_date_otgruzka is not null or prod_id not in (select t.prod_id from disp_kuhni t where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and t.mat_descr<>'нет' and t.sklad_gotov_fakt is null))"
                        + " and (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) and (vse=1 or vse=" + vivaprocess.Global.vse + ") order by prod_id,prod_in,client_name,prod_name";
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
                    DataGridViewRow row = new DataGridViewRow();
                    cel0.Style.BackColor = Color.LightGray;
                    cel1.Value = (string)reader.GetString(0);
                    cel0.Value = (int)reader.GetDecimal(1);
                    cel2.Value = (string)reader.GetString(3);
                    cel3.Value = (string)reader.GetString(2);
                    if (reader.GetString(4).Length > 2)
                    {
                        cel4.Value = DateTime.ParseExact((string)reader.GetString(4), "dd.M.yy", null);
                    }
                    //cel4.Value = (string)reader.GetString(4);
                    if (reader.GetString(5).Length > 2)
                    {
                        cel5.Value = DateTime.ParseExact((string)reader.GetString(5), "dd.M.yy", null);
                    }
                    //cel5.Value = (string)reader.GetString(5);
                    if (reader.GetString(6).Length > 2)
                    {
                        cel6.Value = DateTime.ParseExact((string)reader.GetString(6), "dd.M.yy", null);
                    }
                    //cel6.Value = (string)reader.GetString(6);
                    cel7.Value = (string)reader.GetString(7);
                    cel8.Value = (string)reader.GetDecimal(8).ToString();
                    if (reader.GetString(9).Length > 2)
                    {
                        cel9.Value = DateTime.ParseExact((string)reader.GetString(9), "dd.M.yy", null);
                    }
                    //cel9.Value = (string)reader.GetString(9);
                    cel10.Value = (string)reader.GetString(10);
                    row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4, cel5, cel6, cel7, cel8, cel9, cel10);
                    this.gridKuhni.Rows.Add(row);
                }
                gridKuhni.Columns[0].Frozen = true;
                gridKuhni.Columns[1].Frozen = true;
                gridKuhni.Columns[4].DefaultCellStyle.Format = "d";
                gridKuhni.Columns[5].DefaultCellStyle.Format = "d";
                gridKuhni.Columns[6].DefaultCellStyle.Format = "d";
                gridKuhni.Columns[9].DefaultCellStyle.Format = "d";
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
        private void gridKuhni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int perGreen = 0;
                int perYellow = 0;
                int perRed = 0;
                int bColor = 0;
                string tmpLen0, tmpLen;
                string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con2 = new OracleConnection(constr);
                try
                {
                    con2.Open();
                    OracleCommand cmd2 = con2.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select vars_name, vars_value from vars";
                    OracleDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        switch ((string)reader2.GetString(0))
                        {
                            case "period_color_green":
                                {
                                    perGreen = int.Parse((string)reader2.GetString(1));
                                    break;
                                }
                            case "period_color_yellow":
                                {
                                    perYellow = int.Parse((string)reader2.GetString(1));
                                    break;
                                }
                            case "period_color_red":
                                {
                                    perRed = int.Parse((string)reader2.GetString(1));
                                    break;
                                }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con2.Dispose();
                }

                this.gridMater.Rows.Clear();
                gridMater.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Материал";
                col0.Name = "mat_name";
                col0.ReadOnly = true;
                //col0.Frozen = true;
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "Описание";
                col1.Name = "mat_descr";
                col1.ReadOnly = true;
                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "в производство план";
                col2.Name = "proizvod_plan";
                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "в производство факт";
                col3.Name = "proizvod_fakt";
                col3.ReadOnly = true;
                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "примечание производства";
                col4.Name = "proizvod_descr";
                col4.ReadOnly = true;
                DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
                col5.HeaderText = "на покраску план";
                col5.Name = "kraska_plan";
                col5.ReadOnly = true;
                DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
                col6.HeaderText = "на покраску факт";
                col6.Name = "kraska_fakt";
                col6.ReadOnly = true;
                DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
                col7.HeaderText = "в ОТК план";
                col7.Name = "otk_plan";
                col7.ReadOnly = true;
                DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
                col8.HeaderText = "в ОТК факт";
                col8.Name = "otk_fakt";
                col8.ReadOnly = true;
                DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
                col9.HeaderText = "контроль сборка план";
                col9.Name = "kontrol_sborka_plan";
                col9.ReadOnly = true;
                DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
                col10.HeaderText = "контроль сборка факт";
                col10.Name = "kontrol_sborka_fakt";
                col10.ReadOnly = true;
                DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
                col11.HeaderText = "примечание";
                col11.Name = "otk_descr";
                col11.ReadOnly = true;
                DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
                col12.HeaderText = "приход на склад план";
                col12.Name = "sklad_gotov_plan";
                col12.ReadOnly = true;
                DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
                col13.HeaderText = "приход на склад факт";
                col13.Name = "sklad_gotov_fakt";
                col13.ReadOnly = true;
                DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();
                col14.HeaderText = "Заявка в снабжение";
                col14.Name = "snabgen_zayavka";
                col14.ReadOnly = true;
                DataGridViewTextBoxColumn col15 = new DataGridViewTextBoxColumn();
                col15.HeaderText = "Обработка заявки (инфо)";
                col15.Name = "snabgen_info";
                col15.ReadOnly = true;
                DataGridViewTextBoxColumn col16 = new DataGridViewTextBoxColumn();
                col16.HeaderText = "Поступление на склад матер-ла";
                col16.Name = "material_na_sklad";
                col16.ReadOnly = true;

                if (fl_greed == 0)
                {
                    this.gridMater.Columns.Add(col0);
                    this.gridMater.Columns.Add(col1);
                    this.gridMater.Columns.Add(col2);
                    this.gridMater.Columns.Add(col3);
                    this.gridMater.Columns.Add(col4);
                    this.gridMater.Columns.Add(col5);
                    this.gridMater.Columns.Add(col6);
                    this.gridMater.Columns.Add(col7);
                    this.gridMater.Columns.Add(col8);
                    this.gridMater.Columns.Add(col9);
                    this.gridMater.Columns.Add(col10);
                    this.gridMater.Columns.Add(col11);
                    this.gridMater.Columns.Add(col12);
                    this.gridMater.Columns.Add(col13);
                    this.gridMater.Columns.Add(col14);
                    this.gridMater.Columns.Add(col15);
                    this.gridMater.Columns.Add(col16);
                }
                fl_greed = 1;
                //string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con1 = new OracleConnection(constr);
                try
                {
                    con1.Open();
                    OracleCommand cmd = con1.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select mat_name, nvl(mat_descr,' ') mat_descr, nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt,"
                        + " nvl(proizvod_descr,' ') proizvod_descr,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt,"
                        + "nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt,nvl(to_char(kontrol_sborka_plan,'dd.mm.yy'),' ') kontrol_sborka_plan,nvl(to_char(kontrol_sborka_fakt,'dd.mm.yy'),' ') kontrol_sborka_fakt,"
                        + "nvl(otk_descr,' ') otk_descr,nvl(to_char(sklad_gotov_plan,'dd.mm.yy'),' ') sklad_gotov_plan,nvl(to_char(sklad_gotov_fakt,'dd.mm.yy'),' ') sklad_gotov_fakt,nvl(to_char(snabgen_zayavka,'dd.mm.yy'),' ') snabgen_zayavka,"
                        + "nvl(snabgen_info,' ') snabgen_info,nvl(material_na_sklad,' ') material_na_sklad, item_id, (proizvod_plan-trunc(sysdate)) proizvod_plan_diff,(kraska_plan-trunc(sysdate)) kraska_plan_diff"
                        + ",(otk_plan-trunc(sysdate)) otk_plan_diff,(kontrol_sborka_plan-trunc(sysdate)) kontrol_sborka_plan_diff,(sklad_gotov_plan-trunc(sysdate)) sklad_gotov_plan_diff"
                        + " FROM disp_kuhni where prod_id='" + gridKuhni[0, e.RowIndex].Value.ToString() + "' order by item_id";
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
                        DataGridViewCell cel14 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel15 = new DataGridViewTextBoxCell();
                        DataGridViewCell cel16 = new DataGridViewTextBoxCell();
                        DataGridViewRow row = new DataGridViewRow();
                        cel0.Style.BackColor = Color.LightGray;
                        cel0.Value = (string)reader.GetString(0);
                        cel1.Value = (string)reader.GetString(1);
                        tmpLen0 = (string)reader.GetString(2);
                        cel2.Value = tmpLen0;
                        tmpLen = (string)reader.GetString(3);
                        if (tmpLen.Length < 2 & tmpLen0.Length > 1 & (string)reader.GetString(1)!="нет")
                        {
                            bColor = (int)reader.GetDecimal(reader.GetOrdinal("proizvod_plan_diff")); //(DateTime.Now - DateTime.ParseExact((string)reader.GetString(2), "ddMyyyy", null)).Days;
                            if (bColor <= perGreen & bColor > perYellow)
                            {
                                cel2.Style.BackColor = Color.LimeGreen;
                            }
                            else if (bColor <= perYellow & bColor > perRed)
                            {
                                cel2.Style.BackColor = Color.Yellow;
                            }
                            else if (bColor <= perRed)
                            {
                                cel2.Style.BackColor = Color.Red;
                            }
                        }
                        cel3.Value = tmpLen;
                        cel4.Value = (string)reader.GetString(4);
                        tmpLen0 = (string)reader.GetString(5);
                        cel5.Value = tmpLen0;
                        tmpLen = (string)reader.GetString(6);
                        if (tmpLen.Length < 2 & tmpLen0.Length > 1 & (string)reader.GetString(1) != "нет")
                        {
                            bColor = (int)reader.GetDecimal(reader.GetOrdinal("kraska_plan_diff"));
                            if (bColor <= perGreen & bColor > perYellow)
                            {
                                cel5.Style.BackColor = Color.LimeGreen;
                            }
                            else if (bColor <= perYellow & bColor > perRed)
                            {
                                cel5.Style.BackColor = Color.Yellow;
                            }
                            else if (bColor <= perRed)
                            {
                                cel5.Style.BackColor = Color.Red;
                            }
                        }
                        cel6.Value = tmpLen;
                        //cel7.Value = (string)reader.GetString(7);
                        //cel8.Value = (string)reader.GetString(8);
                        tmpLen0 = (string)reader.GetString(7);
                        cel7.Value = tmpLen0;
                        tmpLen = (string)reader.GetString(8);
                        if (tmpLen.Length < 2 & tmpLen0.Length > 1 & (string)reader.GetString(1) != "нет")
                        {
                            bColor = (int)reader.GetDecimal(reader.GetOrdinal("otk_plan_diff"));
                            if (bColor <= perGreen & bColor > perYellow)
                            {
                                cel7.Style.BackColor = Color.LimeGreen;
                            }
                            else if (bColor <= perYellow & bColor > perRed)
                            {
                                cel7.Style.BackColor = Color.Yellow;
                            }
                            else if (bColor <= perRed)
                            {
                                cel7.Style.BackColor = Color.Red;
                            }
                        }
                        cel8.Value = tmpLen;
                        //cel9.Value = (string)reader.GetString(9);
                        //cel10.Value = (string)reader.GetString(10);
                        tmpLen0 = (string)reader.GetString(9);
                        cel9.Value = tmpLen0;
                        tmpLen = (string)reader.GetString(10);
                        if (tmpLen.Length < 2 & tmpLen0.Length > 1 & (string)reader.GetString(1) != "нет")
                        {
                            bColor = (int)reader.GetDecimal(reader.GetOrdinal("kontrol_sborka_plan_diff"));
                            if (bColor <= perGreen & bColor > perYellow)
                            {
                                cel9.Style.BackColor = Color.LimeGreen;
                            }
                            else if (bColor <= perYellow & bColor > perRed)
                            {
                                cel9.Style.BackColor = Color.Yellow;
                            }
                            else if (bColor <= perRed)
                            {
                                cel9.Style.BackColor = Color.Red;
                            }
                        }
                        cel10.Value = tmpLen;
                        cel11.Value = (string)reader.GetString(11);
                        //cel12.Value = (string)reader.GetString(12);
                        //cel13.Value = (string)reader.GetString(13);
                        tmpLen0 = (string)reader.GetString(12);
                        cel12.Value = tmpLen0;
                        tmpLen = (string)reader.GetString(13);
                        if (tmpLen.Length < 2 & tmpLen0.Length > 1 & (string)reader.GetString(1) != "нет")
                        {
                            bColor = (int)reader.GetDecimal(reader.GetOrdinal("sklad_gotov_plan_diff"));
                            if (bColor <= perGreen & bColor > perYellow)
                            {
                                cel12.Style.BackColor = Color.LimeGreen;
                            }
                            else if (bColor <= perYellow & bColor > perRed)
                            {
                                cel12.Style.BackColor = Color.Yellow;
                            }
                            else if (bColor <= perRed)
                            {
                                cel12.Style.BackColor = Color.Red;
                            }
                        }
                        cel13.Value = tmpLen;
                        cel14.Value = (string)reader.GetString(14);
                        cel15.Value = (string)reader.GetString(15);
                        cel16.Value = (string)reader.GetString(16);
                        row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4, cel5, cel6, cel7, cel8, cel9, cel10, cel11, cel12, cel13, cel14, cel15, cel16);
                        this.gridMater.Rows.Add(row);
                    }
                    gridMater.Columns[0].Frozen = true;

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
        }

        private void frmInfo_Load(object sender, EventArgs e)
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
            this.gridMater.Rows.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (gridKuhni.RowCount>0)
            { 
                rptKuhni1 rptKuhni1F = new rptKuhni1();
                /*OracleConnectionParameters connectionParameters = new OracleConnectionParameters(vivaprocess.Global.ora_serv, "kuhni_modul", "kuhni");
                SqlDataSource ds = new SqlDataSource(connectionParameters);
                CustomSqlQuery query = new CustomSqlQuery();
                query.Name = "customQuery1";
                query.Sql = "select prod_id,prod_name,nvl(client_name,' ') client_name,nvl(prod_descr,' ') prod_descr,nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_date_in,"
                        + " nvl(to_char(prod_date_need,'dd.mm.yy'),' ') prod_date_need,mat_name mat_name, nvl(mat_descr,' ') mat_descr,nvl(to_char(date_tehnol,'dd.mm.yy'),' ') date_tehnol,"
                        + " nvl(tehnolog,' ') tehnolog,nvl(to_char(proizvod_plan,'dd.mm.yy'),' ') proizvod_plan,nvl(to_char(proizvod_fakt,'dd.mm.yy'),' ') proizvod_fakt,"
                        + " nvl(proizvod_descr,' ') proizvod_descr,nvl(to_char(kraska_plan,'dd.mm.yy'),' ') kraska_plan,nvl(to_char(kraska_fakt,'dd.mm.yy'),' ') kraska_fakt,"
                        + " nvl(to_char(otk_plan,'dd.mm.yy'),' ') otk_plan,nvl(to_char(otk_fakt,'dd.mm.yy'),' ') otk_fakt,nvl(to_char(kontrol_sborka_plan,'dd.mm.yy'),' ') сборка_план,"
                        + " nvl(to_char(kontrol_sborka_fakt,'dd.mm.yy'),' ') сборка_факт,nvl(otk_descr,' ') примеч_отк,nvl(to_char(sklad_gotov_plan,'dd.mm.yy'),' ') скл_гот_план,"
                        + " nvl(to_char(sklad_gotov_fakt,'dd.mm.yy'),' ') скл_гот_факт,nvl(to_char(snabgen_zayavka,'dd.mm.yy'),' ') снабж_заявка,"
                        + " nvl(snabgen_info,' ') обработка_снабж,nvl(material_na_sklad,' ') матер_склад,nvl(prod_cena,0) цена,"
                        + " nvl(to_char(prod_date_otgruzka,'dd.mm.yy'),' ') отгруз_факт,nvl(prod_descr_otgruzka,' ') примечания"
                        + " FROM disp_kuhni"; // where (prod_date_in between to_date('" + dateStart.Text + "','dd.mm.yyyy') and to_date('" + dateEnd.Text + "','dd.mm.yyyy')) order by prod_date_in,prod_id,item_id";

                ds.Queries.Add(query);
                ds.Fill();
                rptKuhni1F.DataSource = ds;
                rptKuhni1F.DataMember = "customQuery1";*/
                vivaprocess.Global.rptStart = dateStart.Text;
                vivaprocess.Global.rptEnd = dateEnd.Text;
                //rptKuhni1F.FilterString = "[MAT_DESCR] <> 'нет' And [PROD_DATE_IN] Between(#" + dateStart.DateTime.ToString("yyyy-MM-dd") + "#, #" + dateEnd.DateTime.ToString("yyyy-MM-dd") + "#)";
                //rptKuhni1F.FilterString = "[PROD_DATE_IN] Between(#" + dateStart.DateTime.ToString("yyyy-MM-dd") + "#, #" + dateEnd.DateTime.ToString("yyyy-MM-dd") + "#)";

                //gridKuhni[0, e.RowIndex].Value.ToString()
                int i = 0;
                string rptFilter = "[PROD_ID] In (" + gridKuhni[0, 0].Value.ToString();
                for (i = 1; i<=gridKuhni.RowCount-1; i++)
                {
                    rptFilter = rptFilter + "," + gridKuhni[0, i].Value.ToString();
                }
                rptKuhni1F.FilterString = rptFilter + ")"; //"[PROD_ID] In (1, 2)"
                rptKuhni1F.ShowPreview();
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
