namespace vivaprocess
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.panelTehnolog = new DevExpress.XtraEditors.GroupControl();
            this.btnDelTehnolog = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTehnolog = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblClientId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpTehnolog = new DevExpress.XtraEditors.LookUpEdit();
            this.BindSourceTehnolog = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataTehnolog = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.txtTehnolog = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSavePeriodColor = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtYellow = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGreen = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelManager = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddManager = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpManager = new DevExpress.XtraEditors.LookUpEdit();
            this.BindSourceManager = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataManager = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.txtManager = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTehnolog)).BeginInit();
            this.panelTehnolog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTehnolog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceTehnolog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTehnolog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYellow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGreen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManager.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTehnolog
            // 
            this.panelTehnolog.CaptionImage = ((System.Drawing.Image)(resources.GetObject("panelTehnolog.CaptionImage")));
            this.panelTehnolog.Controls.Add(this.btnDelTehnolog);
            this.panelTehnolog.Controls.Add(this.btnAddTehnolog);
            this.panelTehnolog.Controls.Add(this.labelControl6);
            this.panelTehnolog.Controls.Add(this.lblClientId);
            this.panelTehnolog.Controls.Add(this.labelControl1);
            this.panelTehnolog.Controls.Add(this.lookUpTehnolog);
            this.panelTehnolog.Controls.Add(this.txtTehnolog);
            this.panelTehnolog.Location = new System.Drawing.Point(12, 12);
            this.panelTehnolog.Name = "panelTehnolog";
            this.panelTehnolog.Size = new System.Drawing.Size(362, 138);
            this.panelTehnolog.TabIndex = 0;
            this.panelTehnolog.Text = "Технологи";
            // 
            // btnDelTehnolog
            // 
            this.btnDelTehnolog.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelTehnolog.Appearance.Options.UseFont = true;
            this.btnDelTehnolog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelTehnolog.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTehnolog.Image")));
            this.btnDelTehnolog.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelTehnolog.Location = new System.Drawing.Point(114, 93);
            this.btnDelTehnolog.Name = "btnDelTehnolog";
            this.btnDelTehnolog.Size = new System.Drawing.Size(111, 39);
            this.btnDelTehnolog.TabIndex = 22;
            this.btnDelTehnolog.Text = "Удалить";
            this.btnDelTehnolog.Click += new System.EventHandler(this.btnDelTehnolog_Click);
            // 
            // btnAddTehnolog
            // 
            this.btnAddTehnolog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTehnolog.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddTehnolog.Appearance.Options.UseFont = true;
            this.btnAddTehnolog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAddTehnolog.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTehnolog.Image")));
            this.btnAddTehnolog.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddTehnolog.Location = new System.Drawing.Point(246, 93);
            this.btnAddTehnolog.Name = "btnAddTehnolog";
            this.btnAddTehnolog.Size = new System.Drawing.Size(111, 39);
            this.btnAddTehnolog.TabIndex = 21;
            this.btnAddTehnolog.Text = "Добавить";
            this.btnAddTehnolog.Click += new System.EventHandler(this.btnAddTehnolog_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl6.Appearance.Image")));
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl6.Location = new System.Drawing.Point(5, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 23);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Список";
            // 
            // lblClientId
            // 
            this.lblClientId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblClientId.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClientId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClientId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblClientId.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblClientId.Location = new System.Drawing.Point(45, 90);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(63, 20);
            this.lblClientId.TabIndex = 19;
            this.lblClientId.Text = "client_id";
            this.lblClientId.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(5, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 23);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Технолог";
            // 
            // lookUpTehnolog
            // 
            this.lookUpTehnolog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpTehnolog.Location = new System.Drawing.Point(114, 27);
            this.lookUpTehnolog.Name = "lookUpTehnolog";
            this.lookUpTehnolog.Properties.AutoHeight = false;
            this.lookUpTehnolog.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTehnolog.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PERS_ID", "PERS_ID", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PERS_NAME", "Технологи", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpTehnolog.Properties.DataSource = this.BindSourceTehnolog;
            this.lookUpTehnolog.Properties.DisplayMember = "PERS_NAME";
            this.lookUpTehnolog.Properties.ValueMember = "PERS_ID";
            this.lookUpTehnolog.Size = new System.Drawing.Size(243, 23);
            this.lookUpTehnolog.TabIndex = 16;
            this.lookUpTehnolog.EditValueChanged += new System.EventHandler(this.lookUpTehnolog_EditValueChanged);
            // 
            // BindSourceTehnolog
            // 
            this.BindSourceTehnolog.DataMember = "PERSONAL";
            this.BindSourceTehnolog.DataSource = this.sqlDataTehnolog;
            // 
            // sqlDataTehnolog
            // 
            this.sqlDataTehnolog.ConnectionName = "moderndb_ora";
            this.sqlDataTehnolog.Name = "sqlDataTehnolog";
            tableQuery1.FilterString = "[PERSONAL.PERS_TYPE] = \'технолог\'";
            tableQuery1.Name = "PERSONAL";
            tableInfo1.Name = "PERSONAL";
            columnInfo1.Name = "PERS_ID";
            columnInfo2.Name = "PERS_NAME";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1});
            this.sqlDataTehnolog.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataTehnolog.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVRlaG5vbG9nIj48VmlldyBOYW1lPSJQRVJTT05BTCI+PEZpZWxkI" +
    "E5hbWU9IlBFUlNfSUQiIFR5cGU9IkRlY2ltYWwiIC8+PEZpZWxkIE5hbWU9IlBFUlNfTkFNRSIgVHlwZ" +
    "T0iU3RyaW5nIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // txtTehnolog
            // 
            this.txtTehnolog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTehnolog.EditValue = "";
            this.txtTehnolog.Location = new System.Drawing.Point(114, 64);
            this.txtTehnolog.Name = "txtTehnolog";
            this.txtTehnolog.Properties.AutoHeight = false;
            this.txtTehnolog.Size = new System.Drawing.Size(243, 23);
            this.txtTehnolog.TabIndex = 18;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSavePeriodColor);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtRed);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtYellow);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtGreen);
            this.groupControl2.Location = new System.Drawing.Point(12, 156);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(363, 112);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Подсветка интервалов времени";
            // 
            // btnSavePeriodColor
            // 
            this.btnSavePeriodColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePeriodColor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSavePeriodColor.Appearance.Options.UseFont = true;
            this.btnSavePeriodColor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSavePeriodColor.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePeriodColor.Image")));
            this.btnSavePeriodColor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSavePeriodColor.Location = new System.Drawing.Point(114, 45);
            this.btnSavePeriodColor.Name = "btnSavePeriodColor";
            this.btnSavePeriodColor.Size = new System.Drawing.Size(111, 39);
            this.btnSavePeriodColor.TabIndex = 25;
            this.btnSavePeriodColor.Text = "Сохранить";
            this.btnSavePeriodColor.Click += new System.EventHandler(this.btnSavePeriodColor_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(5, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 23);
            this.labelControl4.TabIndex = 23;
            // 
            // txtRed
            // 
            this.txtRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRed.EditValue = "0";
            this.txtRed.Location = new System.Drawing.Point(65, 82);
            this.txtRed.Name = "txtRed";
            this.txtRed.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRed.Properties.AutoHeight = false;
            this.txtRed.Properties.Mask.EditMask = "d";
            this.txtRed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRed.Size = new System.Drawing.Size(43, 23);
            this.txtRed.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(5, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 23);
            this.labelControl3.TabIndex = 21;
            // 
            // txtYellow
            // 
            this.txtYellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYellow.EditValue = "0";
            this.txtYellow.Location = new System.Drawing.Point(65, 53);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Properties.Appearance.Options.UseTextOptions = true;
            this.txtYellow.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtYellow.Properties.AutoHeight = false;
            this.txtYellow.Properties.Mask.EditMask = "d";
            this.txtYellow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtYellow.Size = new System.Drawing.Size(43, 23);
            this.txtYellow.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Lime;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(5, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 23);
            this.labelControl2.TabIndex = 19;
            // 
            // txtGreen
            // 
            this.txtGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGreen.EditValue = "0";
            this.txtGreen.Location = new System.Drawing.Point(65, 24);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGreen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGreen.Properties.AutoHeight = false;
            this.txtGreen.Properties.Mask.EditMask = "d";
            this.txtGreen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGreen.Size = new System.Drawing.Size(43, 23);
            this.txtGreen.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.btnDelManager);
            this.groupControl1.Controls.Add(this.btnAddManager);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lookUpManager);
            this.groupControl1.Controls.Add(this.txtManager);
            this.groupControl1.Location = new System.Drawing.Point(381, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 138);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Менеджеры";
            // 
            // btnDelManager
            // 
            this.btnDelManager.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelManager.Appearance.Options.UseFont = true;
            this.btnDelManager.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelManager.Image = ((System.Drawing.Image)(resources.GetObject("btnDelManager.Image")));
            this.btnDelManager.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelManager.Location = new System.Drawing.Point(114, 93);
            this.btnDelManager.Name = "btnDelManager";
            this.btnDelManager.Size = new System.Drawing.Size(111, 39);
            this.btnDelManager.TabIndex = 22;
            this.btnDelManager.Text = "Удалить";
            this.btnDelManager.Click += new System.EventHandler(this.btnDelManager_Click);
            // 
            // btnAddManager
            // 
            this.btnAddManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddManager.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddManager.Appearance.Options.UseFont = true;
            this.btnAddManager.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAddManager.Image = ((System.Drawing.Image)(resources.GetObject("btnAddManager.Image")));
            this.btnAddManager.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddManager.Location = new System.Drawing.Point(246, 93);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(111, 39);
            this.btnAddManager.TabIndex = 21;
            this.btnAddManager.Text = "Добавить";
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.Location = new System.Drawing.Point(5, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 23);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Список";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.Location = new System.Drawing.Point(45, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 20);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "client_id";
            this.labelControl7.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl8.Appearance.Image")));
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl8.Location = new System.Drawing.Point(5, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 23);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Менеджер";
            // 
            // lookUpManager
            // 
            this.lookUpManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpManager.Location = new System.Drawing.Point(114, 27);
            this.lookUpManager.Name = "lookUpManager";
            this.lookUpManager.Properties.AutoHeight = false;
            this.lookUpManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpManager.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PERS_ID", "PERS_ID", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PERS_NAME", "Менеджер", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpManager.Properties.DataSource = this.BindSourceManager;
            this.lookUpManager.Properties.DisplayMember = "PERS_NAME";
            this.lookUpManager.Properties.ValueMember = "PERS_ID";
            this.lookUpManager.Size = new System.Drawing.Size(243, 23);
            this.lookUpManager.TabIndex = 16;
            this.lookUpManager.EditValueChanged += new System.EventHandler(this.lookUpManager_EditValueChanged);
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
            tableQuery2.FilterString = "[PERSONAL.PERS_TYPE] = \'manager\'";
            tableQuery2.Name = "PERSONAL";
            tableInfo2.Name = "PERSONAL";
            columnInfo3.Name = "PERS_ID";
            columnInfo4.Name = "PERS_NAME";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo3,
            columnInfo4});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo2});
            this.sqlDataManager.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery2});
            this.sqlDataManager.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YU1hbmFnZXIiPjxWaWV3IE5hbWU9IlBFUlNPTkFMIj48RmllbGQgT" +
    "mFtZT0iUEVSU19JRCIgVHlwZT0iRGVjaW1hbCIgLz48RmllbGQgTmFtZT0iUEVSU19OQU1FIiBUeXBlP" +
    "SJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // txtManager
            // 
            this.txtManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManager.EditValue = "";
            this.txtManager.Location = new System.Drawing.Point(114, 64);
            this.txtManager.Name = "txtManager";
            this.txtManager.Properties.AutoHeight = false;
            this.txtManager.Size = new System.Drawing.Size(243, 23);
            this.txtManager.TabIndex = 18;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 279);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelTehnolog);
            this.Name = "frmOptions";
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTehnolog)).EndInit();
            this.panelTehnolog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTehnolog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceTehnolog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTehnolog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYellow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGreen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManager.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl panelTehnolog;
        private DevExpress.XtraEditors.SimpleButton btnDelTehnolog;
        private DevExpress.XtraEditors.SimpleButton btnAddTehnolog;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblClientId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpTehnolog;
        private DevExpress.XtraEditors.TextEdit txtTehnolog;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataTehnolog;
        private System.Windows.Forms.BindingSource BindSourceTehnolog;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSavePeriodColor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRed;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtYellow;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGreen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelManager;
        private DevExpress.XtraEditors.SimpleButton btnAddManager;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lookUpManager;
        private DevExpress.XtraEditors.TextEdit txtManager;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataManager;
        private System.Windows.Forms.BindingSource BindSourceManager;
    }
}