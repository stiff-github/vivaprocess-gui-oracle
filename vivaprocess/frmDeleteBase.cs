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
    public partial class frmDeleteBase : Form
    {
        int fl_greed = 0;
        public frmDeleteBase()
        {
            InitializeComponent();
        }

        private void frmDeleteBase_Load(object sender, EventArgs e)
        {

        }
        public void refresh_kuhni()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            this.gridKuhni.Rows.Clear();
            gridKuhni.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewCheckBoxColumn col0 = new DataGridViewCheckBoxColumn();
            col0.HeaderText = "Удалить";
            col0.Name = "if_del";
            col0.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "№ заказа";
            col1.Name = "prod_id";
            col1.ReadOnly = true;
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "№ клиента";
            col2.Name = "client_name";
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Дата поступ";
            col3.Name = "prod_date_in";
            col3.ReadOnly = true;
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Описание";
            col4.Name = "prod_descr";
            col4.ReadOnly = true;
            if (fl_greed == 0)
            {
                this.gridKuhni.Columns.Add(col0);
                this.gridKuhni.Columns.Add(col1);
                this.gridKuhni.Columns.Add(col2);
                this.gridKuhni.Columns.Add(col3);
                this.gridKuhni.Columns.Add(col4);
            }
            fl_greed = 1;
            string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con1 = new OracleConnection(constr);
            try
            {
                con1.Open();
                OracleCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from (select distinct prod_name,nvl(prod_id,0) prod_id,nvl(prod_descr,' ') prod_descr,nvl(client_name,' ') client_name,"
                                + " nvl(to_char(prod_date_in,'dd.mm.yy'),' ') prod_in,prod_date_in FROM disp_kuhni order by prod_date_in) where rownum<=" + Convert.ToInt32(txtCount.Text.Trim());
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewCell cel0 = new DataGridViewCheckBoxCell();
                    DataGridViewCell cel1 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel2 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel3 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel4 = new DataGridViewTextBoxCell();
                    DataGridViewRow row = new DataGridViewRow();
                    cel0.Value = true;
                    cel1.Value = (int)reader.GetDecimal(1);
                    cel2.Value = (string)reader.GetString(0);
                    if (reader.GetString(4).Length > 2)
                    {
                        cel3.Value = DateTime.ParseExact((string)reader.GetString(4), "dd.M.yy", null);
                    }
                    cel4.Value = (string)reader.GetString(2);
                    row.Cells.AddRange(cel0, cel1, cel2, cel3, cel4);
                    this.gridKuhni.Rows.Add(row);
                }
                gridKuhni.Columns[3].DefaultCellStyle.Format = "d";
                gridKuhni.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
        private void btnDeleteZakazi_Click(object sender, EventArgs e)
        {
            if (gridKuhni.RowCount > 0)
            {
                DialogResult Delete = DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены, что хотите удалить отмеченные заказы ?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Delete == System.Windows.Forms.DialogResult.Yes)
                {
                    string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
                    OracleConnection con1 = new OracleConnection(constr);
                    try
                    {
                        con1.Open();
                        OracleCommand cmd = con1.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        for (int i = 0; i < gridKuhni.RowCount; i++)
                        {
                            if (Convert.ToInt32(gridKuhni[0, i].Value) == 1)
                            {
                                cmd.CommandText = "delete reklamac where prod_id=" + Convert.ToInt32(gridKuhni[1, i].Value);
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "delete disp_kuhni where prod_id=" + Convert.ToInt32(gridKuhni[1, i].Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con1.Dispose();
                    }
                    refresh_kuhni();       
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh_kuhni();
        }
    }
}
