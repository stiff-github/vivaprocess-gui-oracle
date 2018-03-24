namespace vivaprocess
{
    partial class frmClients
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.lookUpClients = new DevExpress.XtraEditors.LookUpEdit();
            this.BindSourceClients = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataClients = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtClient = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.lblClientId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveClient = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelClient = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BindSourceManager = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataManager = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.lookUpManager = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpClients.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpManager.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpClients
            // 
            this.lookUpClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpClients.Location = new System.Drawing.Point(121, 12);
            this.lookUpClients.Name = "lookUpClients";
            this.lookUpClients.Properties.AutoHeight = false;
            this.lookUpClients.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpClients.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_ID", "CLIENT_ID", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_NAME", "Клиент", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_TEL", "Телефоны", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_ADDR", "Адрес", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_DESCR", "Описание", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_CODE", "Код клиента", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANAGER", "Менеджер", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpClients.Properties.DataSource = this.BindSourceClients;
            this.lookUpClients.Properties.DisplayMember = "CLIENT_NAME";
            this.lookUpClients.Properties.ValueMember = "CLIENT_ID";
            this.lookUpClients.Size = new System.Drawing.Size(397, 23);
            this.lookUpClients.TabIndex = 0;
            this.lookUpClients.EditValueChanged += new System.EventHandler(this.lookUpClients_EditValueChanged);
            // 
            // BindSourceClients
            // 
            this.BindSourceClients.DataMember = "CLIENTS";
            this.BindSourceClients.DataSource = this.sqlDataClients;
            // 
            // sqlDataClients
            // 
            this.sqlDataClients.ConnectionName = "moderndb_ora";
            this.sqlDataClients.Name = "sqlDataClients";
            customSqlQuery1.Name = "CLIENTS";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataClients.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataClients.ResultSchemaSerializable = resources.GetString("sqlDataClients.ResultSchemaSerializable");
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(12, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Клиент";
            // 
            // txtClient
            // 
            this.txtClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClient.EditValue = "";
            this.txtClient.Location = new System.Drawing.Point(121, 49);
            this.txtClient.Name = "txtClient";
            this.txtClient.Properties.AutoHeight = false;
            this.txtClient.Size = new System.Drawing.Size(397, 23);
            this.txtClient.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.Appearance.Image")));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(12, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Телефоны";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.EditValue = "";
            this.txtTel.Location = new System.Drawing.Point(121, 87);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.AutoHeight = false;
            this.txtTel.Size = new System.Drawing.Size(397, 23);
            this.txtTel.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.Appearance.Image")));
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(12, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Адрес";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.EditValue = "";
            this.txtAdres.Location = new System.Drawing.Point(121, 126);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Properties.AutoHeight = false;
            this.txtAdres.Size = new System.Drawing.Size(397, 23);
            this.txtAdres.TabIndex = 7;
            // 
            // lblClientId
            // 
            this.lblClientId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblClientId.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClientId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClientId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblClientId.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblClientId.Location = new System.Drawing.Point(53, 266);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(63, 20);
            this.lblClientId.TabIndex = 8;
            this.lblClientId.Text = "client_id";
            this.lblClientId.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.Appearance.Image")));
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(12, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 23);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Описание";
            // 
            // txtDescr
            // 
            this.txtDescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescr.EditValue = "";
            this.txtDescr.Location = new System.Drawing.Point(121, 163);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Properties.AutoHeight = false;
            this.txtDescr.Size = new System.Drawing.Size(397, 23);
            this.txtDescr.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.Location = new System.Drawing.Point(12, 201);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 23);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Код клиента";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.EditValue = "";
            this.txtCode.Location = new System.Drawing.Point(121, 201);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.AutoHeight = false;
            this.txtCode.Size = new System.Drawing.Size(397, 23);
            this.txtCode.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl6.Appearance.Image")));
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 23);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Список";
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClient.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveClient.Appearance.Options.UseFont = true;
            this.btnSaveClient.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSaveClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClient.Image")));
            this.btnSaveClient.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveClient.Location = new System.Drawing.Point(407, 277);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(111, 39);
            this.btnSaveClient.TabIndex = 14;
            this.btnSaveClient.Text = "Сохранить";
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnDelClient
            // 
            this.btnDelClient.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelClient.Appearance.Options.UseFont = true;
            this.btnDelClient.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDelClient.Image")));
            this.btnDelClient.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelClient.Location = new System.Drawing.Point(122, 277);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(111, 39);
            this.btnDelClient.TabIndex = 15;
            this.btnDelClient.Text = "Удалить";
            this.btnDelClient.Click += new System.EventHandler(this.btnDelClient_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.Image")));
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.Location = new System.Drawing.Point(12, 239);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 23);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Менеджер";
            // 
            // BindSourceManager
            // 
            this.BindSourceManager.DataMember = "PERSONAL";
            this.BindSourceManager.DataSource = this.sqlDataManager;
            // 
            // sqlDataManager
            // 
            this.sqlDataManager.ConnectionName = "moderndb_ora";
            this.sqlDataManager.Name = "sqlDataManager";
            tableQuery1.FilterString = "[PERSONAL.PERS_TYPE] = \'manager\'";
            tableQuery1.Name = "PERSONAL";
            tableInfo1.Name = "PERSONAL";
            columnInfo1.Name = "PERS_ID";
            columnInfo2.Name = "PERS_NAME";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1});
            this.sqlDataManager.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataManager.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YU1hbmFnZXIiPjxWaWV3IE5hbWU9IlBFUlNPTkFMIj48RmllbGQgT" +
    "mFtZT0iUEVSU19JRCIgVHlwZT0iRGVjaW1hbCIgLz48RmllbGQgTmFtZT0iUEVSU19OQU1FIiBUeXBlP" +
    "SJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // lookUpManager
            // 
            this.lookUpManager.Location = new System.Drawing.Point(122, 240);
            this.lookUpManager.Name = "lookUpManager";
            this.lookUpManager.Properties.AutoHeight = false;
            this.lookUpManager.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpManager.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PERS_ID", "PERS_ID", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PERS_NAME", "Менеджер", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpManager.Properties.DataSource = this.BindSourceManager;
            this.lookUpManager.Properties.DisplayMember = "PERS_NAME";
            this.lookUpManager.Properties.ValueMember = "PERS_ID";
            this.lookUpManager.Size = new System.Drawing.Size(394, 23);
            this.lookUpManager.TabIndex = 254;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 332);
            this.Controls.Add(this.lookUpManager);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnDelClient);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpClients);
            this.Controls.Add(this.txtClient);
            this.Name = "frmClients";
            this.Text = "База клиентов";
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpClients.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpManager.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpClients;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtClient;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.LabelControl lblClientId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescr;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.BindingSource BindSourceClients;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataClients;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSaveClient;
        private DevExpress.XtraEditors.SimpleButton btnDelClient;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource BindSourceManager;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataManager;
        private DevExpress.XtraEditors.LookUpEdit lookUpManager;

    }
}