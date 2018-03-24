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
    public partial class frmStatusSpisok : Form
    {
        int fl_greed = 0;
        public frmStatusSpisok()
        {
            InitializeComponent();
        }

        private void form_load(object sender, EventArgs e)
        {
            this.grid1.Rows.Clear();

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "№№";
            col0.Name = "ID";
            col0.ReadOnly = true;
            col0.Visible = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Состояние";
            col1.Name = "status";

            if (fl_greed == 0)
            {
                this.grid1.Columns.Add(col0);
                this.grid1.Columns.Add(col1);
            }
            fl_greed = 1;

            string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con1 = new OracleConnection(constr);
            try
            {
                con1.Open();
                OracleCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id, nvl(status,' ') status FROM status_descr order by status";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewCell cel0 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel1 = new DataGridViewTextBoxCell();
                    DataGridViewRow row = new DataGridViewRow();
                    cel0.Style.BackColor = Color.LightGray;
                    cel0.Value = (int)reader.GetDecimal(0);
                    cel1.Value = (string)reader.GetString(1);
                    row.Cells.AddRange(cel0, cel1);
                    this.grid1.Rows.Add(row);
                }

                //grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //grid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
