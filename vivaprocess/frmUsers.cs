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
    public partial class frmUsers : Form
    {
        //int fl_greed = 0;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void form_load(object sender, EventArgs e)
        {
            DataGridViewCell cel0 = new DataGridViewTextBoxCell();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewRow row = new DataGridViewRow();
            cel0.Value = "руководство";
            cel1.Value="начальник";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "менеджеры";
            cel1.Value = "продавец";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "цех";
            cel1.Value = "цех";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "покраска";
            cel1.Value = "краска";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "склад продукции";
            cel1.Value = "склад";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "снабжение";
            cel1.Value = "купить";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "слежение";
            cel1.Value = "11";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "сбыт начальник";
            cel1.Value = "продать";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "технолог";
            cel1.Value = "базис";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
            cel0 = new DataGridViewTextBoxCell();
            cel1 = new DataGridViewTextBoxCell();
            row = new DataGridViewRow();
            cel0.Value = "нач производства";
            cel1.Value = "начцеха";
            row.Cells.AddRange(cel0, cel1);
            this.gridUser.Rows.Add(row);
        }
    }
}
