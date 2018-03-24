namespace vivaprocess
{
    partial class frmDeleteBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteBase));
            this.gridKuhni = new System.Windows.Forms.DataGridView();
            this.btnDeleteZakazi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridKuhni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKuhni
            // 
            this.gridKuhni.AllowUserToAddRows = false;
            this.gridKuhni.AllowUserToDeleteRows = false;
            this.gridKuhni.AllowUserToOrderColumns = true;
            this.gridKuhni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridKuhni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKuhni.Location = new System.Drawing.Point(2, 2);
            this.gridKuhni.MultiSelect = false;
            this.gridKuhni.Name = "gridKuhni";
            this.gridKuhni.RowHeadersVisible = false;
            this.gridKuhni.Size = new System.Drawing.Size(575, 561);
            this.gridKuhni.TabIndex = 1;
            // 
            // btnDeleteZakazi
            // 
            this.btnDeleteZakazi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteZakazi.Appearance.Options.UseFont = true;
            this.btnDeleteZakazi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDeleteZakazi.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteZakazi.Image")));
            this.btnDeleteZakazi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDeleteZakazi.Location = new System.Drawing.Point(695, 275);
            this.btnDeleteZakazi.Name = "btnDeleteZakazi";
            this.btnDeleteZakazi.Size = new System.Drawing.Size(111, 39);
            this.btnDeleteZakazi.TabIndex = 23;
            this.btnDeleteZakazi.Text = "Удалить";
            this.btnDeleteZakazi.Click += new System.EventHandler(this.btnDeleteZakazi_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(583, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(172, 38);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Сколько старых кухонь подготовить к удалению?";
            // 
            // txtCount
            // 
            this.txtCount.EditValue = "100";
            this.txtCount.Location = new System.Drawing.Point(761, 23);
            this.txtCount.Name = "txtCount";
            this.txtCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCount.Properties.Appearance.Options.UseFont = true;
            this.txtCount.Properties.AutoHeight = false;
            this.txtCount.Size = new System.Drawing.Size(45, 38);
            this.txtCount.TabIndex = 25;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(695, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 39);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Загрузить";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmDeleteBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 565);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnDeleteZakazi);
            this.Controls.Add(this.gridKuhni);
            this.Name = "frmDeleteBase";
            this.Text = "Очистка заказов";
            this.Load += new System.EventHandler(this.frmDeleteBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKuhni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKuhni;
        private DevExpress.XtraEditors.SimpleButton btnDeleteZakazi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}