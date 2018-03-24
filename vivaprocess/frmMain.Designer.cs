namespace vivaprocess
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKuhniSlegenieFull = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSlegenMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInform = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKuhniFull = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReklamacii = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZakazClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOtgruzNeed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOtgruzNeed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOtgruzFakt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptReklamac = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpravochnik = new System.Windows.Forms.ToolStripMenuItem();
            this.стадииПроцессаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKuhniSpr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKategorSlogn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteBase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUserEnter = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserEnter = new DevExpress.XtraEditors.TextEdit();
            this.lblUserEnter = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserEnter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 440);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(969, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // menuMain
            // 
            this.menuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuData,
            this.mnuReport,
            this.mnuSpravochnik,
            this.mnuExit});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(969, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuMain";
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKuhniSlegenieFull,
            this.mnuSlegenMaterial,
            this.mnuInform,
            this.mnuKuhniFull,
            this.mnuReklamacii});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(62, 20);
            this.mnuData.Text = "Данные";
            // 
            // mnuKuhniSlegenieFull
            // 
            this.mnuKuhniSlegenieFull.Name = "mnuKuhniSlegenieFull";
            this.mnuKuhniSlegenieFull.Size = new System.Drawing.Size(186, 22);
            this.mnuKuhniSlegenieFull.Text = "Кухни слежение";
            this.mnuKuhniSlegenieFull.Click += new System.EventHandler(this.mnuKuhniSlegenieFull_Click);
            // 
            // mnuSlegenMaterial
            // 
            this.mnuSlegenMaterial.Name = "mnuSlegenMaterial";
            this.mnuSlegenMaterial.Size = new System.Drawing.Size(186, 22);
            this.mnuSlegenMaterial.Text = "Материал слежение";
            this.mnuSlegenMaterial.Click += new System.EventHandler(this.mnuSlegenMaterial_Click);
            // 
            // mnuInform
            // 
            this.mnuInform.Name = "mnuInform";
            this.mnuInform.Size = new System.Drawing.Size(186, 22);
            this.mnuInform.Text = "Кухни слежение 2";
            this.mnuInform.Click += new System.EventHandler(this.mnuInform_Click);
            // 
            // mnuKuhniFull
            // 
            this.mnuKuhniFull.Name = "mnuKuhniFull";
            this.mnuKuhniFull.Size = new System.Drawing.Size(186, 22);
            this.mnuKuhniFull.Text = "Кухни подробно";
            this.mnuKuhniFull.Click += new System.EventHandler(this.mnuKuhniFull_Click);
            // 
            // mnuReklamacii
            // 
            this.mnuReklamacii.Enabled = false;
            this.mnuReklamacii.Name = "mnuReklamacii";
            this.mnuReklamacii.Size = new System.Drawing.Size(186, 22);
            this.mnuReklamacii.Text = "Рекламации";
            this.mnuReklamacii.Click += new System.EventHandler(this.mnuReklamacii_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuZakazClient,
            this.mnuOtgruzNeed,
            this.mnuOtgruzNeed2,
            this.mnuOtgruzFakt,
            this.mnuRptReklamac});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(60, 20);
            this.mnuReport.Text = "Отчёты";
            // 
            // mnuZakazClient
            // 
            this.mnuZakazClient.Name = "mnuZakazClient";
            this.mnuZakazClient.Size = new System.Drawing.Size(163, 22);
            this.mnuZakazClient.Text = "Заказы клиента";
            this.mnuZakazClient.Click += new System.EventHandler(this.mnuZakazClient_Click);
            // 
            // mnuOtgruzNeed
            // 
            this.mnuOtgruzNeed.Name = "mnuOtgruzNeed";
            this.mnuOtgruzNeed.Size = new System.Drawing.Size(163, 22);
            this.mnuOtgruzNeed.Text = "Отгрузки план";
            this.mnuOtgruzNeed.Click += new System.EventHandler(this.mnuOtgruzNeed_Click);
            // 
            // mnuOtgruzNeed2
            // 
            this.mnuOtgruzNeed2.Name = "mnuOtgruzNeed2";
            this.mnuOtgruzNeed2.Size = new System.Drawing.Size(163, 22);
            this.mnuOtgruzNeed2.Text = "Отгрузки план 2";
            this.mnuOtgruzNeed2.Click += new System.EventHandler(this.mnuOtgruzNeed2_Click);
            // 
            // mnuOtgruzFakt
            // 
            this.mnuOtgruzFakt.Name = "mnuOtgruzFakt";
            this.mnuOtgruzFakt.Size = new System.Drawing.Size(163, 22);
            this.mnuOtgruzFakt.Text = "Отгрузки факт";
            this.mnuOtgruzFakt.Click += new System.EventHandler(this.mnuOtgruzFakt_Click);
            // 
            // mnuRptReklamac
            // 
            this.mnuRptReklamac.Name = "mnuRptReklamac";
            this.mnuRptReklamac.Size = new System.Drawing.Size(163, 22);
            this.mnuRptReklamac.Text = "Рекламации";
            this.mnuRptReklamac.Click += new System.EventHandler(this.mnuRptReklamac_Click);
            // 
            // mnuSpravochnik
            // 
            this.mnuSpravochnik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стадииПроцессаToolStripMenuItem,
            this.mnuKuhniSpr,
            this.mnuUsers,
            this.mnuClients,
            this.mnuKategorSlogn,
            this.mnuOptions,
            this.mnuDeleteBase});
            this.mnuSpravochnik.Name = "mnuSpravochnik";
            this.mnuSpravochnik.Size = new System.Drawing.Size(94, 20);
            this.mnuSpravochnik.Text = "Справочники";
            // 
            // стадииПроцессаToolStripMenuItem
            // 
            this.стадииПроцессаToolStripMenuItem.Name = "стадииПроцессаToolStripMenuItem";
            this.стадииПроцессаToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.стадииПроцессаToolStripMenuItem.Text = "Стадии процесса";
            this.стадииПроцессаToolStripMenuItem.Visible = false;
            this.стадииПроцессаToolStripMenuItem.Click += new System.EventHandler(this.стадииПроцессаToolStripMenuItem_Click);
            // 
            // mnuKuhniSpr
            // 
            this.mnuKuhniSpr.Name = "mnuKuhniSpr";
            this.mnuKuhniSpr.Size = new System.Drawing.Size(195, 22);
            this.mnuKuhniSpr.Text = "Кухни";
            this.mnuKuhniSpr.Visible = false;
            this.mnuKuhniSpr.Click += new System.EventHandler(this.mnuKuhniSpr_Click);
            // 
            // mnuUsers
            // 
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(195, 22);
            this.mnuUsers.Text = "Пользователи";
            this.mnuUsers.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // mnuClients
            // 
            this.mnuClients.Name = "mnuClients";
            this.mnuClients.Size = new System.Drawing.Size(195, 22);
            this.mnuClients.Text = "Клиенты";
            this.mnuClients.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // mnuKategorSlogn
            // 
            this.mnuKategorSlogn.Name = "mnuKategorSlogn";
            this.mnuKategorSlogn.Size = new System.Drawing.Size(195, 22);
            this.mnuKategorSlogn.Text = "Категории сложности";
            this.mnuKategorSlogn.Click += new System.EventHandler(this.mnuKategorSlogn_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(195, 22);
            this.mnuOptions.Text = "Параметры";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // mnuDeleteBase
            // 
            this.mnuDeleteBase.Name = "mnuDeleteBase";
            this.mnuDeleteBase.Size = new System.Drawing.Size(195, 22);
            this.mnuDeleteBase.Text = "Очистка";
            this.mnuDeleteBase.Click += new System.EventHandler(this.mnuDeleteBase_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(53, 20);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnUserEnter
            // 
            this.btnUserEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserEnter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnUserEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnUserEnter.Image")));
            this.btnUserEnter.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnUserEnter.Location = new System.Drawing.Point(844, 2);
            this.btnUserEnter.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserEnter.Name = "btnUserEnter";
            this.btnUserEnter.Size = new System.Drawing.Size(63, 20);
            this.btnUserEnter.TabIndex = 4;
            this.btnUserEnter.Click += new System.EventHandler(this.btnUserEnter_Click);
            // 
            // txtUserEnter
            // 
            this.txtUserEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserEnter.EditValue = "";
            this.txtUserEnter.Location = new System.Drawing.Point(736, 2);
            this.txtUserEnter.Name = "txtUserEnter";
            this.txtUserEnter.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtUserEnter.Properties.PasswordChar = '*';
            this.txtUserEnter.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtUserEnter.Size = new System.Drawing.Size(106, 20);
            this.txtUserEnter.TabIndex = 5;
            this.txtUserEnter.Click += new System.EventHandler(this.txtUserEnter_Click);
            this.txtUserEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserEnter_KeyDown);
            // 
            // lblUserEnter
            // 
            this.lblUserEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserEnter.Location = new System.Drawing.Point(626, 5);
            this.lblUserEnter.Name = "lblUserEnter";
            this.lblUserEnter.Size = new System.Drawing.Size(106, 13);
            this.lblUserEnter.TabIndex = 7;
            this.lblUserEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 462);
            this.Controls.Add(this.lblUserEnter);
            this.Controls.Add(this.txtUserEnter);
            this.Controls.Add(this.btnUserEnter);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuMain);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Система слежения за производством ViVakitchen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserEnter.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuInform;
        private System.Windows.Forms.ToolStripMenuItem mnuSpravochnik;
        private System.Windows.Forms.ToolStripMenuItem mnuKuhniSpr;
        private System.Windows.Forms.ToolStripMenuItem стадииПроцессаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuKuhniSlegenieFull;
        private System.Windows.Forms.ToolStripMenuItem mnuKuhniFull;
        private System.Windows.Forms.ToolStripMenuItem mnuClients;
        private System.Windows.Forms.ToolStripMenuItem mnuKategorSlogn;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private DevExpress.XtraEditors.SimpleButton btnUserEnter;
        private DevExpress.XtraEditors.TextEdit txtUserEnter;
        private System.Windows.Forms.Label lblUserEnter;
        private System.Windows.Forms.ToolStripMenuItem mnuReklamacii;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuOtgruzNeed;
        private System.Windows.Forms.ToolStripMenuItem mnuRptReklamac;
        private System.Windows.Forms.ToolStripMenuItem mnuZakazClient;
        private System.Windows.Forms.ToolStripMenuItem mnuOtgruzFakt;
        private System.Windows.Forms.ToolStripMenuItem mnuOtgruzNeed2;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteBase;
        private System.Windows.Forms.ToolStripMenuItem mnuSlegenMaterial;
    }
}

