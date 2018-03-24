namespace vivaprocess
{
    partial class frmRptReklamac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptReklamac));
            this.chkOtgrugen = new System.Windows.Forms.CheckBox();
            this.chkInWork = new System.Windows.Forms.CheckBox();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.gridKuhni = new System.Windows.Forms.DataGridView();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKuhni)).BeginInit();
            this.SuspendLayout();
            // 
            // chkOtgrugen
            // 
            this.chkOtgrugen.AutoSize = true;
            this.chkOtgrugen.Location = new System.Drawing.Point(433, 9);
            this.chkOtgrugen.Name = "chkOtgrugen";
            this.chkOtgrugen.Size = new System.Drawing.Size(81, 17);
            this.chkOtgrugen.TabIndex = 279;
            this.chkOtgrugen.Text = "отгружена";
            this.chkOtgrugen.UseVisualStyleBackColor = true;
            // 
            // chkInWork
            // 
            this.chkInWork.AutoSize = true;
            this.chkInWork.Checked = true;
            this.chkInWork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInWork.Location = new System.Drawing.Point(347, 9);
            this.chkInWork.Name = "chkInWork";
            this.chkInWork.Size = new System.Drawing.Size(71, 17);
            this.chkInWork.TabIndex = 277;
            this.chkInWork.Text = "в работе";
            this.chkInWork.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseTextOptions = true;
            this.btnLoad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(236, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 23);
            this.btnLoad.TabIndex = 276;
            this.btnLoad.Text = "загрузить";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 275;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 274;
            this.label1.Text = "с";
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = new System.DateTime(2016, 12, 20, 0, 0, 0, 0);
            this.dateEnd.Location = new System.Drawing.Point(141, 3);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.AutoHeight = false;
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEnd.Size = new System.Drawing.Size(80, 23);
            this.dateEnd.TabIndex = 273;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = new System.DateTime(2016, 12, 20, 0, 0, 0, 0);
            this.dateStart.Location = new System.Drawing.Point(30, 3);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.AutoHeight = false;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Size = new System.Drawing.Size(80, 23);
            this.dateStart.TabIndex = 272;
            // 
            // gridKuhni
            // 
            this.gridKuhni.AllowUserToAddRows = false;
            this.gridKuhni.AllowUserToDeleteRows = false;
            this.gridKuhni.AllowUserToOrderColumns = true;
            this.gridKuhni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKuhni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKuhni.Location = new System.Drawing.Point(12, 51);
            this.gridKuhni.Name = "gridKuhni";
            this.gridKuhni.ReadOnly = true;
            this.gridKuhni.Size = new System.Drawing.Size(882, 438);
            this.gridKuhni.TabIndex = 271;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseTextOptions = true;
            this.btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(775, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 40);
            this.btnPrint.TabIndex = 280;
            this.btnPrint.Text = "распечатать";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmRptReklamac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 503);
            this.Controls.Add(this.chkOtgrugen);
            this.Controls.Add(this.chkInWork);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.gridKuhni);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmRptReklamac";
            this.Text = "Отчёт по рекламациям";
            this.Load += new System.EventHandler(this.frmRptReklamac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKuhni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOtgrugen;
        private System.Windows.Forms.CheckBox chkInWork;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private System.Windows.Forms.DataGridView gridKuhni;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}