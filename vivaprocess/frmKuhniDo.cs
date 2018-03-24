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
using System.Diagnostics;

using System.IO;
using System.IO.Compression;

namespace vivaprocess
{
    public partial class frmKuhniDo : Form
    {
        int fl_greed=0;
        public frmKuhniDo()
        {
            InitializeComponent();
        }

        public static void UnZip(string path)
        {
            string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
            string zip2;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                string[] zips = Directory.GetFiles(@vivaprocess.Global.path_zip, "*.zip");
                int i = 0;
                int fNum=1;
                foreach (string zip in zips)
                {
                    i = i+1;
                    zip2=System.IO.Path.GetFileNameWithoutExtension(zip);
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select nvl((SELECT max(id) as num FROM test_kuhni),0)+1 as num from dual";
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fNum = (int)reader.GetDecimal(0);
                    }
                    cmd.CommandText = "insert into test_kuhni(id, nomer) values(" + fNum + ",'" + zip2 + "')";
                    cmd.ExecuteNonQuery();
            
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = @Application.StartupPath.ToString() + "\\7z.exe";
                    ps.Arguments = @"x " + zip + " -o" + vivaprocess.Global.path_now + " -y";
                    Process procCommand = Process.Start(ps);
                    procCommand.WaitForExit();
                    FileInfo file = new FileInfo(zip);
                    if (file.Exists == true) //Если файл существует
                    {
                        file.Delete(); //Удаляем
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = vivaprocess.Global.station_type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.grid1.Rows.Clear();
            var list_status = new List<string>();
            int i=0;
            string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
            OracleConnection con = new OracleConnection(constr);
            try
            {
                con.Open();
                textBox1.Text = "Successfully connected to Oracle!\n";
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nvl(status,' ') status FROM status_descr order by id";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i = i + 1;
                    list_status.Add((string)reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Заказ";
                col0.Name = "nomer";
                col0.ReadOnly = true;
                col0.Frozen = true;
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = "№№";
                col1.Name = "ID";
                col1.ReadOnly = true;
                col1.Visible = false;
                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.HeaderText = "Примечание";
                col2.Name = "descr";
                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Состояние";
                col3.Name = "status";
                DataGridViewComboBoxColumn col4 = new DataGridViewComboBoxColumn();
                col4.DataSource = list_status;
                col4.HeaderText = "Новое состояние";
                col4.Name = "new";
                DataGridViewButtonColumn col5 = new DataGridViewButtonColumn();
                col5.HeaderText = "Редактирование";
                col5.Name = "save";
                col5.Text = "Сохранить";
                col5.UseColumnTextForButtonValue = true;
                if (fl_greed == 0)
                {
                    this.grid1.Columns.Add(col0);
                    this.grid1.Columns.Add(col1);
                    this.grid1.Columns.Add(col2);
                    this.grid1.Columns.Add(col3);
                    this.grid1.Columns.Add(col4);
                    this.grid1.Columns.Add(col5);
                }
                fl_greed = 1;

            OracleConnection con1 = new OracleConnection(constr);
            try
            {
                    con1.Open();
                    textBox1.Text = "Successfully connected to Oracle!\n";
                    OracleCommand cmd = con1.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select id, nomer, nvl(descr,' ') descr, nvl(status,' ') status FROM test_kuhni";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewCell cel0 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel1 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel2 = new DataGridViewTextBoxCell();
                    DataGridViewCell cel3 = new DataGridViewTextBoxCell();
                    DataGridViewComboBoxCell cel4 = new DataGridViewComboBoxCell();
                    DataGridViewRow row = new DataGridViewRow();
                    cel0.Style.BackColor = Color.LightGray;
                    cel0.Value = (string)reader.GetString(1);
                    cel1.Value = (int)reader.GetDecimal(0);
                    cel2.Value = (string)reader.GetString(2);
                    cel3.Value = (string)reader.GetString(3);
                    row.Cells.AddRange(cel0, cel1, cel2, cel3);
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
            textBox1.Text =textBox1.Text + "\n ENTER to continue...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnZip(vivaprocess.Global.path_zip);
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                label2.Text=grid1[1,e.RowIndex].Value.ToString();
                string constr = "User Id=kuhni_modul; Password=kuhni; Data Source=" + vivaprocess.Global.ora_serv;
                OracleConnection con = new OracleConnection(constr);
                try
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update test_kuhni set descr='" + grid1[2, e.RowIndex].Value.ToString() + "', status='" + grid1[4, e.RowIndex].Value.ToString() + "' where id=" + grid1[1, e.RowIndex].Value.ToString();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Dispose();
                }
            }
        }

    }
}
