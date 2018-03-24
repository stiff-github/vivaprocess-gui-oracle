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

namespace vivaprocess
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            sqlDataTehnolog.Fill();
            sqlDataManager.Fill();
        }

        private void btnDelTehnolog_Click(object sender, EventArgs e)
        {
            DialogResult DelTehnolog = DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены, что хотите удалить технолога ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DelTehnolog == System.Windows.Forms.DialogResult.Yes)
            {
                string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con = new OracleConnection(constr);
                try
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete personal where pers_name='" + txtTehnolog.Text.Trim() + "'";
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
                this.sqlDataTehnolog.Fill();
                lookUpTehnolog.ItemIndex = 0;
            }
        }

        private void btnAddTehnolog_Click(object sender, EventArgs e)
        {
            int fTehno = 0;
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT count(pers_name) as num FROM personal where pers_name='" + txtTehnolog.Text.Trim() + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fTehno = (int)reader.GetDecimal(0);
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

            if (fTehno == 0)
            {
                if (txtTehnolog.Text.Length > 0)
                {
                    constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                    con = new OracleConnection(constr);
                    try
                    {
                        int fNum = 1;
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select nvl((SELECT max(pers_id) as num FROM personal),0)+1 as num from dual";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            fNum = (int)reader.GetDecimal(0);
                        }
                        cmd.CommandText = "insert into personal(pers_id,pers_type,pers_name) values(" + fNum + ",'технолог','" + txtTehnolog.Text.Trim() + "')";
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
                    this.sqlDataTehnolog.Fill();
                    lookUpTehnolog.EditValue = lookUpTehnolog.Properties.GetKeyValueByDisplayText(txtTehnolog.Text);
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Заполните поля..", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult DelClient = DevExpress.XtraEditors.XtraMessageBox.Show("Такой технолог существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lookUpTehnolog_EditValueChanged(object sender, EventArgs e)
        {
            txtTehnolog.Text = lookUpTehnolog.Properties.GetDataSourceValue("PERS_NAME", lookUpTehnolog.ItemIndex).ToString().Trim();
        }

        private void btnSavePeriodColor_Click(object sender, EventArgs e)
        {
            int fColor = 0;
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT count(vars_name) as num FROM vars where vars_name like '%period_color%'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fColor = (int)reader.GetDecimal(0);
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

            if (fColor == 0)
            {
                constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                con = new OracleConnection(constr);
                try
                {
                    int fNum = 1;
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select nvl((SELECT max(vars_id) as num FROM vars),0)+1 as num from dual";
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fNum = (int)reader.GetDecimal(0);
                    }
                    cmd.CommandText = "insert into vars(vars_id,vars_name,vars_value) values(" + fNum + ",'period_color_green','" + txtGreen.Text + "')";
                    cmd.ExecuteNonQuery();
                    fNum += 1;
                    cmd.CommandText = "insert into vars(vars_id,vars_name,vars_value) values(" + fNum + ",'period_color_yellow','" + txtYellow.Text + "')";
                    cmd.ExecuteNonQuery();
                    fNum += 1;
                    cmd.CommandText = "insert into vars(vars_id,vars_name,vars_value) values(" + fNum + ",'period_color_red','" + txtRed.Text + "')";
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
            }
            else
            {
                constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                con = new OracleConnection(constr);
                try
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "update vars set vars_value='" + txtGreen.Text + "' where vars_name='period_color_green'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update vars set vars_value='" + txtYellow.Text + "' where vars_name='period_color_yellow'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update vars set vars_value='" + txtRed.Text + "' where vars_name='period_color_red'";
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
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            lookUpTehnolog.ItemIndex = 0;
            lookUpManager.ItemIndex = 0;
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT vars_name, vars_value FROM vars where vars_name like '%period_color%'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    switch ((string)reader.GetString(0))
                    {
                        case "period_color_green":
                            txtGreen.Text = (string)reader.GetString(1);
                            break;
                        case "period_color_yellow":
                            txtYellow.Text = (string)reader.GetString(1);
                            break;
                        case "period_color_red":
                            txtRed.Text = (string)reader.GetString(1);
                            break;
                    }
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
        }

        private void btnDelManager_Click(object sender, EventArgs e)
        {
            DialogResult DelTehnolog = DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены, что хотите удалить менеджера ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DelTehnolog == System.Windows.Forms.DialogResult.Yes)
            {
                string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con = new OracleConnection(constr);
                try
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete personal where pers_name='" + txtManager.Text.Trim() + "'";
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
                this.sqlDataManager.Fill();
                lookUpManager.ItemIndex = 0;
            }
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            int fTehno = 0;
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT count(pers_name) as num FROM personal where pers_name='" + txtManager.Text.Trim() + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fTehno = (int)reader.GetDecimal(0);
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

            if (fTehno == 0)
            {
                if (txtManager.Text.Length > 0)
                {
                    constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                    con = new OracleConnection(constr);
                    try
                    {
                        int fNum = 1;
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select nvl((SELECT max(pers_id) as num FROM personal),0)+1 as num from dual";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            fNum = (int)reader.GetDecimal(0);
                        }
                        cmd.CommandText = "insert into personal(pers_id,pers_type,pers_name) values(" + fNum + ",'manager','" + txtManager.Text.Trim() + "')";
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
                    this.sqlDataManager.Fill();
                    lookUpManager.EditValue = lookUpManager.Properties.GetKeyValueByDisplayText(txtManager.Text);
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Заполните поля..", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult DelClient = DevExpress.XtraEditors.XtraMessageBox.Show("Такой менеджер существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lookUpManager_EditValueChanged(object sender, EventArgs e)
        {
            txtManager.Text = lookUpManager.Properties.GetDataSourceValue("PERS_NAME", lookUpManager.ItemIndex).ToString().Trim();
        }
    }
}
