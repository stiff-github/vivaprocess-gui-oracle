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
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;

namespace vivaprocess
{
    public partial class frmReklamac : DevExpress.XtraEditors.XtraForm
    {
        public frmReklamac()
        {
            InitializeComponent();
        }
        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            OracleConnectionParameters connectionParameters = new OracleConnectionParameters(vivaprocess.Global.ora_serv, "kuhni_modul", "kuhni");
            SqlDataSource ds = new SqlDataSource(connectionParameters);
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = "customQuery1";
            query.Sql = "select ITEM_ID,prod_id as NN,prod_name as NN_КЛИЕНТА,client_name as КЛИЕНТ,reklamac_name as РЕКЛАМАЦИЯ,date_in as ДАТА_ПОСТУПЛ,"
                        + " date_out as ДАТА_ВЫПОЛН from REKLAMAC where date_in is null"
                        + " or (date_in between trunc(ADD_MONTHS((last_day(to_date('" + dateViewZakaz.Text + "','dd.mm.yyyy'))), 0), 'MM')"
                        + " and trunc(last_day(to_date('" + dateViewZakaz.Text + "','dd.mm.yyyy')))) order by PROD_ID, reklamac_name";
            sqlKuhni.Queries.Clear();
            sqlKuhni.Queries.Add(query);
            sqlKuhni.Fill();
            bindKuhni.DataSource = sqlKuhni;
            bindKuhni.DataMember = "customQuery1";
            lookUpKuhni.Properties.DataSource = bindKuhni;
            lookUpKuhni.Properties.ValueMember = "ITEM_ID";
            lookUpKuhni.Properties.DisplayMember = "РЕКЛАМАЦИЯ";
            lookUpKuhni.Properties.PopulateColumns();
            lookUpKuhni.Properties.Columns["ITEM_ID"].Visible = false;
            lookUpKuhni.Properties.Columns["NN"].FormatType = DevExpress.Utils.FormatType.Numeric;
            lookUpKuhni.Properties.Columns["NN"].FormatString = "n0";
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void frmReklamac_Load(object sender, EventArgs e)
        {
            dateViewZakaz.Text = DateTime.Now.ToString("dd.MM.yyyy");
            if (vivaprocess.Global.zakazReklamac.Length>1)
            {
                if (vivaprocess.Global.zakazReklamac.IndexOf(',') > -1)
                {
                    vivaprocess.Global.zakazReklamac = vivaprocess.Global.zakazReklamac.Substring(0, vivaprocess.Global.zakazReklamac.IndexOf(','));
                }
                else if (vivaprocess.Global.zakazReklamac.IndexOf('.') > -1)
                {
                    vivaprocess.Global.zakazReklamac = vivaprocess.Global.zakazReklamac.Substring(0, vivaprocess.Global.zakazReklamac.IndexOf('.'));
                }
                txtZakaz.Text = vivaprocess.Global.zakazReklamac;
                txtZakazC.Text = vivaprocess.Global.zakazReklamacC;
                txtClient.Text = vivaprocess.Global.zakazReklamacCl;
                dateRekIn.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
            refresh_kuhni();
            if (vivaprocess.Global.prava == "нач производства" || vivaprocess.Global.prava == "технолог" || vivaprocess.Global.prava == "цех" || vivaprocess.Global.prava == "склад продукции" || vivaprocess.Global.prava == "снабжение")
            {
                btnDelRek.Enabled = false;
                btnSaveRek.Enabled = false;
            }
        }

        private void btnSaveRek_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT count(ITEM_ID) as num FROM REKLAMAC where PROD_ID=" + txtZakaz.Text + " and"
                        + " reklamac_name='" + txtRek.Text + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    flag = (int)reader.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }

            if (flag == 0)
            {
                if (txtRek.Text.Length > 0)
                {
                    constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                    con = new OracleConnection(constr);
                    try
                    {
                        int fNum = 1;
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select nvl((SELECT max(item_id) as num FROM REKLAMAC),0)+1 as num from dual";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            fNum = (int)reader.GetDecimal(0);
                        }
                        cmd.CommandText = "insert into REKLAMAC(item_id,prod_id,reklamac_name,reklamac_descr,reklamac_otdel,reklamac_pers,date_in,date_need,"
                                + " date_out,out_descr,prod_name,client_name,stoim) values(" + fNum + "," + txtZakaz.Text.Trim() + ",'" + txtRek.Text.Trim() + "','" + txtRekDescr.Text.Trim() + "'"
                                + ",'" + txtOtdel.Text.Trim() + "','" + txtVin.Text.Trim() + "',trunc(to_date('" + dateRekIn.Text.Trim() + "','dd.mm.yyyy hh24:mi:ss')),"
                                + "trunc(to_date('" + dateRekPlan.Text.Trim() + "','dd.mm.yyyy hh24:mi:ss')),trunc(to_date('" + dateRekFakt.Text.Trim() + "','dd.mm.yyyy hh24:mi:ss')),"
                                + "'" + txtOutDescr.Text.Trim() + "','" + txtZakazC.Text.Trim() + "','" + txtClient.Text.Trim() + "'," + txtStoim.Text.Trim() + ")";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Dispose();
                    }
                    //sql_log("insert.");
                    refresh_kuhni();
                    lookUpKuhni.EditValue = lookUpKuhni.Properties.GetKeyValueByDisplayText(txtRek.Text);
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Заполните поля..", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult DelClient = DevExpress.XtraEditors.XtraMessageBox.Show("Такая рекламация существует, обновить информацию ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DelClient == System.Windows.Forms.DialogResult.Yes)
                {
                    constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                    con = new OracleConnection(constr);
                    try
                    {
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandText = "update REKLAMAC set reklamac_name='" + txtRek.Text.Trim() + "', reklamac_descr='" + txtRekDescr.Text.Trim() + "', out_descr='" + txtOutDescr.Text.Trim() + "'"
                                + ", date_in=trunc(to_date('" + dateRekIn.Text.Trim() + "','dd.mm.yyyy hh24:mi:ss')), date_need=trunc(to_date('" + dateRekPlan.Text.Trim() + "','dd.mm.yyyy hh24:mi:ss'))"
                                + ", date_out=trunc(to_date('" + dateRekFakt.Text.Trim() + "','dd.mm.yyyy hh24:mi:ss')), stoim=" + txtStoim.Text.Trim() + " "
                                + " where ITEM_ID=" + lookUpKuhni.Properties.GetDataSourceValue("ITEM_ID", lookUpKuhni.ItemIndex) +"";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Dispose();
                    }
                    //sql_log("update.");
                    refresh_kuhni();
                }
            }
        }

        private void dateViewZakaz_EditValueChanged(object sender, EventArgs e)
        {
            refresh_kuhni();
        }

        private void lookUpKuhni_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select item_id,prod_id,prod_name,nvl(client_name,' ') client_name,nvl(to_char(date_in,'dd.mm.yyyy'),' ') date_in,"
                    + "nvl(reklamac_name,' ') reklamac_name,nvl(reklamac_descr,' ') reklamac_descr,"
                    + "nvl(reklamac_otdel,' ') reklamac_otdel,nvl(reklamac_pers,' ') reklamac_pers,"
                    + "nvl(to_char(date_need,'dd.mm.yyyy'),' ') date_need,nvl(to_char(date_out,'dd.mm.yyyy'),' ') date_out,nvl(out_descr,' ') out_descr,nvl(stoim,0) stoim"
                    + " FROM REKLAMAC where item_id=round(" + lookUpKuhni.Properties.GetDataSourceValue("ITEM_ID", lookUpKuhni.ItemIndex) + ")";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtZakaz.Text = (string)reader.GetDecimal(1).ToString();
                    txtZakazC.Text = (string)reader.GetString(2);
                    txtClient.Text = (string)reader.GetString(3);
                    dateRekIn.Text = (string)reader.GetString(4);
                    txtRek.Text = (string)reader.GetString(5);
                    txtRekDescr.Text = (string)reader.GetString(6);
                    txtOtdel.Text = (string)reader.GetString(7);
                    txtVin.Text = (string)reader.GetString(8);
                    dateRekPlan.Text = (string)reader.GetString(9);
                    dateRekFakt.Text = (string)reader.GetString(10);
                    txtOutDescr.Text = (string)reader.GetString(11);
                    txtStoim.Text = (string)reader.GetDecimal(12).ToString();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void btnDelRek_Click(object sender, EventArgs e)
        {
            DialogResult DelRekl = DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены, что хотите удалить рекламацию ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DelRekl == System.Windows.Forms.DialogResult.Yes)
            {
                string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con = new OracleConnection(constr);
                try
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete REKLAMAC where item_id=" + lookUpKuhni.Properties.GetDataSourceValue("ITEM_ID", lookUpKuhni.ItemIndex) + "";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Dispose();
                }
                lookUpKuhni.ItemIndex = -1;
                refresh_kuhni();
            }
        }
    }
}