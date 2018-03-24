using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vivaprocess
{
    public partial class frmMain : Form
    {
        frmInfo frmInfoF;
        //frmKuhniDo frmKuhniDoF;
        frmStatusSpisok frmStatusSpisokF;
        frmUsers frmUsersF;
        frmTest frmTestF;
        frmKuhniFull frmKuhniFullF;
        frmClients frmClientsF;
        frmCategorSlogn frmCategorSlognF;
        frmOptions frmOptionsF;
        frmKuhniSlegFull frmKuhniSlegFullF;
        frmReklamac frmReklamacF;
        frmRptOtgruzNeed frmRptOtgruzNeedF;
        frmRptOtgruzNeed2 frmRptOtgruzNeed2F;
        frmRptOtgruzFakt frmRptOtgruzFaktF;
        frmRptReklamac frmRptReklamacF;
        frmRptZakazClient frmRptZakazClientF;
        frmDeleteBase frmDeleteBaseF;
        frmSlegenMaterial frmSlegenMaterialF;
        public frmMain()
        {
            InitializeComponent();
            mnuReklamacii.Visible = false;
            mnuZakazClient.Visible = false;
            mnuOtgruzNeed2.Visible = false;
            mnuOtgruzFakt.Visible = false;
            mnuRptReklamac.Visible = false;
            стадииПроцессаToolStripMenuItem.Visible = false;
            mnuUsers.Visible = false;
            mnuDeleteBase.Visible = false;
            lblUserEnter.BackColor = Color.Red;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            vivaprocess.Global.flagExit = 1;
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUserEnter.Focus();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (vivaprocess.Global.flagExit != 1)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void mnuInform_Click(object sender, EventArgs e)
        {
            if (frmInfoF == null || frmInfoF.IsDisposed)
            {
                frmInfoF = new frmInfo();
                frmInfoF.MdiParent = this;
                frmInfoF.Show();
            }
            else
            {
                frmInfoF.Activate();
            }
        }

        private void mnuKuhniSpr_Click(object sender, EventArgs e)
        {
            if (frmTestF == null || frmTestF.IsDisposed)
            {
                frmTestF = new frmTest();
                frmTestF.MdiParent = this;
                frmTestF.Show();
            }
            else
            {
                frmTestF.Activate();
            }
        }

        private void стадииПроцессаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStatusSpisokF == null || frmStatusSpisokF.IsDisposed)
            {
                frmStatusSpisokF = new frmStatusSpisok();
                frmStatusSpisokF.MdiParent = this;
                frmStatusSpisokF.Show();
            }
            else
            {
                frmStatusSpisokF.Activate();
            }
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUsersF == null || frmUsersF.IsDisposed)
            {
                frmUsersF = new frmUsers();
                frmUsersF.MdiParent = this;
                frmUsersF.Show();
            }
            else
            {
                frmUsersF.Activate();
            }
        }

        public void mnuKuhniFull_Click(object sender, System.EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (frmKuhniFullF == null || frmKuhniFullF.IsDisposed)
            {
                frmKuhniFullF = new frmKuhniFull();
                frmKuhniFullF.MdiParent = this;
                frmKuhniFullF.Show();
            }
            else
            {
                frmKuhniFullF.Activate();
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmClientsF == null || frmClientsF.IsDisposed)
            {
                frmClientsF = new frmClients();
                frmClientsF.MdiParent = this;
                frmClientsF.Show();
            }
            else
            {
                frmClientsF.Activate();
            }
        }

        private void mnuKategorSlogn_Click(object sender, EventArgs e)
        {
            if (frmCategorSlognF == null || frmCategorSlognF.IsDisposed)
            {
                frmCategorSlognF = new frmCategorSlogn();
                frmCategorSlognF.MdiParent = this;
                frmCategorSlognF.Show();
            }
            else
            {
                frmCategorSlognF.Activate();
            }
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            if (frmOptionsF == null || frmOptionsF.IsDisposed)
            {
                frmOptionsF = new frmOptions();
                frmOptionsF.MdiParent = this;
                frmOptionsF.Show();
            }
            else
            {
                frmOptionsF.Activate();
            }
        }

        private void mnuKuhniSlegenieFull_Click(object sender, EventArgs e)
        {
            if (frmKuhniSlegFullF == null || frmKuhniSlegFullF.IsDisposed)
            {
                frmKuhniSlegFullF = new frmKuhniSlegFull();
                frmKuhniSlegFullF.MdiParent = this;
                frmKuhniSlegFullF.Show();
            }
            else
            {
                frmKuhniSlegFullF.Activate();
            }
        }

        private void btnUserEnter_Click(object sender, EventArgs e)
        {
            if (txtUserEnter.Text.Trim() == "admin33" || txtUserEnter.Text.Trim() == "фвьшт33")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                стадииПроцессаToolStripMenuItem.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                //txtUserEnter.Properties.PasswordChar = '\0';
                //txtUserEnter.Text = "adminko";
                lblUserEnter.Text = "adminko";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = true;
                mnuDeleteBase.Enabled = true;
                mnuOptions.Enabled = true;
                mnuKategorSlogn.Enabled = true;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = true;
            }
            /*else if (txtUserEnter.Text.Trim() == "33")
            {
                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "adminko";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = true;
                mnuOptions.Enabled = true;
                mnuKategorSlogn.Enabled = true;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = true;
            }*/
            else if (txtUserEnter.Text.Trim() == "ghjlfdtw" || txtUserEnter.Text.Trim() == "продавец")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "менеджеры";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuOptions.Enabled = true;
                mnuKategorSlogn.Enabled = true;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = true;
            }
            else if (txtUserEnter.Text.Trim() == "ghjlfnm" || txtUserEnter.Text.Trim() == "продать")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "сбыт начальник";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuOptions.Enabled = true;
                mnuKategorSlogn.Enabled = true;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = true;
            }
            else if (txtUserEnter.Text.Trim() == "yfxwt[f" || txtUserEnter.Text.Trim() == "начцеха")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "нач производства";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuClients.Enabled = false;
                mnuOptions.Enabled = false;
                mnuKategorSlogn.Enabled = false;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = true;
            }
            else if (txtUserEnter.Text.Trim() == ",fpbc" || txtUserEnter.Text.Trim() == "базис")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = false;
                lblUserEnter.Text = "технолог";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuClients.Enabled = false;
                mnuOptions.Enabled = false;
                mnuKategorSlogn.Enabled = false;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = false;
            }
            else if (txtUserEnter.Text.Trim() == "regbnm" || txtUserEnter.Text.Trim() == "купить")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "снабжение";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuOptions.Enabled = false;
                mnuKategorSlogn.Enabled = false;
                mnuKuhniFull.Enabled = true;
                mnuReport.Enabled = false;
            }
            else if (txtUserEnter.Text.Trim() == "wt[" || txtUserEnter.Text.Trim() == "цех")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = false;
                lblUserEnter.Text = "цех";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuOptions.Enabled = false;
                mnuKategorSlogn.Enabled = false;
                mnuKuhniFull.Enabled = true;
                mnuReport.Enabled = false;
            }
            else if (txtUserEnter.Text.Trim() == "rhfcrf" || txtUserEnter.Text.Trim() == "краска")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "покраска";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuOptions.Enabled = false;
                mnuKategorSlogn.Enabled = false;
                mnuKuhniFull.Enabled = true;
                mnuReport.Enabled = false;
            }
            else if (txtUserEnter.Text.Trim() == "crkfl" || txtUserEnter.Text.Trim() == "склад")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = false;
                lblUserEnter.Text = "склад продукции";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = false;
                mnuDeleteBase.Enabled = false;
                mnuOptions.Enabled = false;
                mnuKategorSlogn.Enabled = false;
                mnuKuhniFull.Enabled = true;
                mnuReport.Enabled = true;
                mnuZakazClient.Enabled = false;
                mnuOtgruzFakt.Enabled = false;
                mnuRptReklamac.Enabled = false;
            }
            else if (txtUserEnter.Text.Trim() == "yfxfkmybr" || txtUserEnter.Text.Trim() == "начальник")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;
                mnuDeleteBase.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = true;
                lblUserEnter.Text = "руководство";
                txtUserEnter.Text = "";

                mnuUsers.Enabled = true;
                mnuDeleteBase.Enabled = true;
                mnuOptions.Enabled = true;
                mnuKategorSlogn.Enabled = true;
                mnuKuhniFull.Enabled = true;
                mnuReklamacii.Enabled = true;
                mnuReport.Enabled = true;
            }
            else if (txtUserEnter.Text.Trim() == "11ckt;tybt")
            {
                vivaprocess.Global.vse = 0;
                lblUserEnter.BackColor = Color.LightGray;
                mnuReklamacii.Visible = true;
                mnuZakazClient.Visible = true;
                mnuOtgruzNeed2.Visible = true;
                mnuOtgruzFakt.Visible = true;
                mnuRptReklamac.Visible = true;
                mnuUsers.Visible = true;

                mnuData.Enabled = true;
                mnuSpravochnik.Enabled = false;
                lblUserEnter.Text = "слежение";
                txtUserEnter.Text = "";

                mnuKuhniFull.Enabled = false;
                mnuReport.Enabled = false;
            }
            else
            {
                vivaprocess.Global.vse = 1;
                lblUserEnter.BackColor = Color.Red;
                //mnuData.Enabled = false;
                //mnuReport.Enabled = true;
                //mnuSpravochnik.Enabled = Enabled;
                mnuReklamacii.Visible = false;
                mnuZakazClient.Visible = false;
                mnuOtgruzNeed2.Visible = false;
                mnuOtgruzFakt.Visible = false;
                mnuRptReklamac.Visible = false;
                mnuUsers.Visible = false;
                mnuDeleteBase.Visible = false;
                txtUserEnter.Text = "";
                lblUserEnter.Text = "";
            }
            vivaprocess.Global.prava = lblUserEnter.Text;
        }

        private void txtUserEnter_Click(object sender, EventArgs e)
        {
            txtUserEnter.Properties.PasswordChar = '*';
        }

        private void txtUserEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnUserEnter_Click(this, null);
        }

        private void mnuReklamacii_Click(object sender, EventArgs e)
        {
            if (frmReklamacF == null || frmReklamacF.IsDisposed)
            {
                frmReklamacF = new frmReklamac();
                frmReklamacF.MdiParent = this;
                frmReklamacF.Show();
            }
            else
            {
                frmReklamacF.Activate();
            }
        }

        private void mnuOtgruzNeed_Click(object sender, EventArgs e)
        {
            if (frmRptOtgruzNeedF == null || frmRptOtgruzNeedF.IsDisposed)
            {
                frmRptOtgruzNeedF = new frmRptOtgruzNeed();
                frmRptOtgruzNeedF.MdiParent = this;
                frmRptOtgruzNeedF.Show();
            }
            else
            {
                frmRptOtgruzNeedF.Activate();
            }
        }

        private void mnuRptReklamac_Click(object sender, EventArgs e)
        {
            if (frmRptReklamacF == null || frmRptReklamacF.IsDisposed)
            {
                frmRptReklamacF = new frmRptReklamac();
                frmRptReklamacF.MdiParent = this;
                frmRptReklamacF.Show();
            }
            else
            {
                frmRptReklamacF.Activate();
            }
        }

        private void mnuZakazClient_Click(object sender, EventArgs e)
        {
            if (frmRptZakazClientF == null || frmRptZakazClientF.IsDisposed)
            {
                frmRptZakazClientF = new frmRptZakazClient();
                frmRptZakazClientF.MdiParent = this;
                frmRptZakazClientF.Show();
            }
            else
            {
                frmRptZakazClientF.Activate();
            }
        }

        private void mnuOtgruzFakt_Click(object sender, EventArgs e)
        {
            if (frmRptOtgruzFaktF == null || frmRptOtgruzFaktF.IsDisposed)
            {
                frmRptOtgruzFaktF = new frmRptOtgruzFakt();
                frmRptOtgruzFaktF.MdiParent = this;
                frmRptOtgruzFaktF.Show();
            }
            else
            {
                frmRptOtgruzFaktF.Activate();
            }
        }

        private void mnuOtgruzNeed2_Click(object sender, EventArgs e)
        {
            if (frmRptOtgruzNeed2F == null || frmRptOtgruzNeed2F.IsDisposed)
            {
                frmRptOtgruzNeed2F = new frmRptOtgruzNeed2();
                frmRptOtgruzNeed2F.MdiParent = this;
                frmRptOtgruzNeed2F.Show();
            }
            else
            {
                frmRptOtgruzNeed2F.Activate();
            }
        }

        private void mnuDeleteBase_Click(object sender, EventArgs e)
        {
            if (frmDeleteBaseF == null || frmDeleteBaseF.IsDisposed)
            {
                frmDeleteBaseF = new frmDeleteBase();
                frmDeleteBaseF.MdiParent = this;
                frmDeleteBaseF.Show();
            }
            else
            {
                frmDeleteBaseF.Activate();
            }
        }

        private void mnuSlegenMaterial_Click(object sender, EventArgs e)
        {
            if (frmSlegenMaterialF == null || frmSlegenMaterialF.IsDisposed)
            {
                frmSlegenMaterialF = new frmSlegenMaterial();
                frmSlegenMaterialF.MdiParent = this;
                frmSlegenMaterialF.Show();
            }
            else
            {
                frmSlegenMaterialF.Activate();
            }
        }
    }
}
