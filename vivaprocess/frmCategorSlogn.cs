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
    public partial class frmCategorSlogn : Form
    {
        public frmCategorSlogn()
        {
            InitializeComponent();
            sqlDataCategory.Fill();
        }

    private void lookUpCategory_EditValueChanged(object sender, EventArgs e)
    {
        //lblClientId.Text = lookUpCategory.EditValue.ToString();
        txtCategory.Text = lookUpCategory.Properties.GetDataSourceValue("CATEGORY_NAME", lookUpCategory.ItemIndex).ToString().Trim();
        txtOtgruz.Text = lookUpCategory.Properties.GetDataSourceValue("OTGRUZ", lookUpCategory.ItemIndex).ToString().Trim();
        txtTehnolog.Text = lookUpCategory.Properties.GetDataSourceValue("TEHNOL", lookUpCategory.ItemIndex).ToString().Trim();
        txtCeh.Text = lookUpCategory.Properties.GetDataSourceValue("CEH", lookUpCategory.ItemIndex).ToString().Trim();
        txtSnabgenie.Text = lookUpCategory.Properties.GetDataSourceValue("SNABGENIE", lookUpCategory.ItemIndex).ToString().Trim();
        txtKraska.Text = lookUpCategory.Properties.GetDataSourceValue("KRASKA", lookUpCategory.ItemIndex).ToString().Trim();
        txtOtk.Text = lookUpCategory.Properties.GetDataSourceValue("OTK", lookUpCategory.ItemIndex).ToString().Trim();
        txtKontrolSbor.Text = lookUpCategory.Properties.GetDataSourceValue("KONTROL_SBORKA", lookUpCategory.ItemIndex).ToString().Trim();
        txtPrihodSklad.Text = lookUpCategory.Properties.GetDataSourceValue("SKLAD", lookUpCategory.ItemIndex).ToString().Trim();
        txtMaterialSklad.Text = lookUpCategory.Properties.GetDataSourceValue("MATERIAL_SKLAD", lookUpCategory.ItemIndex).ToString().Trim();
    }

    private void btnSaveClient_Click_1(object sender, EventArgs e)
    {
        int fClient = 0;
        string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
        OracleConnection con = new OracleConnection(constr);
        try
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(category_name) as num FROM CATEGORY_SLOGN where category_name='" + txtCategory.Text.Trim() + "'";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fClient = (int)reader.GetDecimal(0);
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

        if (fClient == 0)
        {
            if (txtCategory.Text.Length > 0)
            {
                constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                con = new OracleConnection(constr);
                try
                {
                    int fNum = 1;
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select nvl((SELECT max(category_id) as num FROM CATEGORY_SLOGN),0)+1 as num from dual";
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fNum = (int)reader.GetDecimal(0);
                    }
                    cmd.CommandText = "insert into CATEGORY_SLOGN(category_id,category_name,otgruz,tehnol,ceh,snabgenie,kraska,otk,kontrol_sborka,sklad,material_sklad) values(" + fNum + ",'" +txtCategory.Text.Trim() + "'," + txtOtgruz.Text.Trim() + "," + txtTehnolog.Text.Trim() + "," + txtCeh.Text.Trim() + "," + txtSnabgenie.Text.Trim() + "," + txtKraska.Text.Trim() + "," + txtOtk.Text.Trim() + "," + txtKontrolSbor.Text.Trim() + "," + txtPrihodSklad.Text.Trim() + "," + txtMaterialSklad.Text.Trim() + ")";
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
                sql_log("insert.");
                this.sqlDataCategory.Fill();
                lookUpCategory.EditValue = lookUpCategory.Properties.GetKeyValueByDisplayText(txtCategory.Text);
                //lblClientId.Text = lookUpCategory.EditValue.ToString();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Заполните правильно поля..", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            DialogResult DelClient = DevExpress.XtraEditors.XtraMessageBox.Show("Такая категория существует, обновить информацию ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DelClient == System.Windows.Forms.DialogResult.Yes)
            {
                constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
                con = new OracleConnection(constr);
                try
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "update CATEGORY_SLOGN set otgruz=" +txtOtgruz.Text.Trim() + ", tehnol=" + txtTehnolog.Text.Trim() + ", ceh=" + txtCeh.Text.Trim() + ", snabgenie=" + txtSnabgenie.Text.Trim() + ", kraska=" + txtKraska.Text.Trim() + ", otk=" + txtOtk.Text.Trim() + ", kontrol_sborka=" + txtKontrolSbor.Text.Trim() + ", sklad=" + txtPrihodSklad.Text.Trim() + ", material_sklad=" + txtMaterialSklad.Text.Trim() + " where category_name='" + txtCategory.Text.Trim() + "'";
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
                sql_log("update.");
                this.sqlDataCategory.Fill();
            }
        }
    }

    private void btnDelClient_Click_1(object sender, EventArgs e)
    {
        DialogResult DelClient = DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены, что хотите удалить категорию ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (DelClient == System.Windows.Forms.DialogResult.Yes)
        {
            string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete CATEGORY_SLOGN where category_name='" + txtCategory.Text.Trim() + "'";
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
            sql_log("delete.");
            this.sqlDataCategory.Fill();
            lookUpCategory.ItemIndex = 0;
        }
    }

    private void sql_log(string log_msg)
    {
        log_msg += SystemInformation.ComputerName.ToString();
        log_msg += "." + vivaprocess.Global.user_this.ToString();
        string constr = "User Id=" + vivaprocess.Global.ora_user + "; Password=" + vivaprocess.Global.ora_pass + "; Data Source=" + vivaprocess.Global.ora_serv;
        OracleConnection con = new OracleConnection(constr);
        try
        {
            int fNum = 1;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nvl((SELECT max(id) as num FROM CATEGORY_SLOGN_LOG),0)+1 as num from dual";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fNum = (int)reader.GetDecimal(0);
            }
            cmd.CommandText = "insert into CATEGORY_SLOGN_LOG(id,in_log) values(" + fNum + ",'" + log_msg + "')";
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

    private void frmCategorSlogn_Load(object sender, EventArgs e)
    {
        lookUpCategory.ItemIndex = 0;
    }

    }
}
