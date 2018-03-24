namespace vivaprocess
{
    partial class frmCategorSlogn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorSlogn));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.btnDelClient = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveClient = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKraska = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSnabgenie = new DevExpress.XtraEditors.TextEdit();
            this.lblClientId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCeh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOtgruz = new DevExpress.XtraEditors.TextEdit();
            this.sqlDataCategory = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.BindSourceCategory = new System.Windows.Forms.BindingSource(this.components);
            this.txtTehnolog = new DevExpress.XtraEditors.TextEdit();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtOtk = new DevExpress.XtraEditors.TextEdit();
            this.txtKontrolSbor = new DevExpress.XtraEditors.TextEdit();
            this.txtPrihodSklad = new DevExpress.XtraEditors.TextEdit();
            this.txtMaterialSklad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKraska.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnabgenie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCeh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtgruz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTehnolog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKontrolSbor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrihodSklad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialSklad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelClient
            // 
            this.btnDelClient.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelClient.Appearance.Options.UseFont = true;
            this.btnDelClient.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDelClient.Image")));
            this.btnDelClient.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelClient.Location = new System.Drawing.Point(115, 353);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(111, 40);
            this.btnDelClient.TabIndex = 30;
            this.btnDelClient.Text = "Удалить";
            this.btnDelClient.Click += new System.EventHandler(this.btnDelClient_Click_1);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClient.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveClient.Appearance.Options.UseFont = true;
            this.btnSaveClient.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSaveClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClient.Image")));
            this.btnSaveClient.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveClient.Location = new System.Drawing.Point(329, 353);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(111, 40);
            this.btnSaveClient.TabIndex = 29;
            this.btnSaveClient.Text = "Сохранить";
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click_1);
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
            this.labelControl6.Size = new System.Drawing.Size(156, 23);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Список категорий";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.Location = new System.Drawing.Point(12, 195);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(156, 23);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "В покраску";
            // 
            // txtKraska
            // 
            this.txtKraska.EditValue = "";
            this.txtKraska.Location = new System.Drawing.Point(174, 196);
            this.txtKraska.Name = "txtKraska";
            this.txtKraska.Properties.AutoHeight = false;
            this.txtKraska.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtKraska.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKraska.Properties.EditFormat.FormatString = "{n0}";
            this.txtKraska.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKraska.Properties.Mask.EditMask = "d";
            this.txtKraska.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKraska.Size = new System.Drawing.Size(52, 23);
            this.txtKraska.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.Appearance.Image")));
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(12, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(156, 23);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "В снабжение заявка";
            // 
            // txtSnabgenie
            // 
            this.txtSnabgenie.EditValue = "";
            this.txtSnabgenie.Location = new System.Drawing.Point(174, 167);
            this.txtSnabgenie.Name = "txtSnabgenie";
            this.txtSnabgenie.Properties.AutoHeight = false;
            this.txtSnabgenie.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtSnabgenie.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSnabgenie.Properties.EditFormat.FormatString = "{n0}";
            this.txtSnabgenie.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSnabgenie.Properties.Mask.EditMask = "d";
            this.txtSnabgenie.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSnabgenie.Size = new System.Drawing.Size(52, 23);
            this.txtSnabgenie.TabIndex = 25;
            // 
            // lblClientId
            // 
            this.lblClientId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblClientId.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClientId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClientId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblClientId.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblClientId.Location = new System.Drawing.Point(12, 373);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(63, 20);
            this.lblClientId.TabIndex = 23;
            this.lblClientId.Text = "client_id";
            this.lblClientId.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.Appearance.Image")));
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(12, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 23);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "В производство";
            // 
            // txtCeh
            // 
            this.txtCeh.EditValue = "";
            this.txtCeh.Location = new System.Drawing.Point(174, 138);
            this.txtCeh.Name = "txtCeh";
            this.txtCeh.Properties.AutoHeight = false;
            this.txtCeh.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtCeh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCeh.Properties.EditFormat.FormatString = "{n0}";
            this.txtCeh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCeh.Properties.Mask.EditMask = "d";
            this.txtCeh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCeh.Size = new System.Drawing.Size(52, 23);
            this.txtCeh.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.Appearance.Image")));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(12, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 23);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Технологи";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(12, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 23);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Отгрузка";
            // 
            // txtOtgruz
            // 
            this.txtOtgruz.EditValue = "";
            this.txtOtgruz.Location = new System.Drawing.Point(174, 79);
            this.txtOtgruz.Name = "txtOtgruz";
            this.txtOtgruz.Properties.AutoHeight = false;
            this.txtOtgruz.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtOtgruz.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOtgruz.Properties.EditFormat.FormatString = "{n0}";
            this.txtOtgruz.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOtgruz.Properties.Mask.EditMask = "d";
            this.txtOtgruz.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOtgruz.Size = new System.Drawing.Size(52, 23);
            this.txtOtgruz.TabIndex = 18;
            // 
            // sqlDataCategory
            // 
            this.sqlDataCategory.ConnectionName = "moderndb_ora";
            this.sqlDataCategory.Name = "sqlDataCategory";
            customSqlQuery3.Name = "CATEGORY_SLOGN";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataCategory.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataCategory.ResultSchemaSerializable = resources.GetString("sqlDataCategory.ResultSchemaSerializable");
            // 
            // BindSourceCategory
            // 
            this.BindSourceCategory.DataMember = "CATEGORY_SLOGN";
            this.BindSourceCategory.DataSource = this.sqlDataCategory;
            // 
            // txtTehnolog
            // 
            this.txtTehnolog.EditValue = "";
            this.txtTehnolog.Location = new System.Drawing.Point(174, 109);
            this.txtTehnolog.Name = "txtTehnolog";
            this.txtTehnolog.Properties.AutoHeight = false;
            this.txtTehnolog.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtTehnolog.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTehnolog.Properties.EditFormat.FormatString = "{n0}";
            this.txtTehnolog.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTehnolog.Properties.Mask.EditMask = "d";
            this.txtTehnolog.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTehnolog.Size = new System.Drawing.Size(52, 23);
            this.txtTehnolog.TabIndex = 20;
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpCategory.Location = new System.Drawing.Point(174, 12);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.AutoHeight = false;
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CATEGORY_ID", "CATEGORY_ID", 94, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CATEGORY_NAME", "Категория", 98, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OTGRUZ", "Отгрузка", 51, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEHNOL", "В техотдел", 49, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CEH", "Производство", 30, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SNABGENIE", "Снабжение", 66, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KRASKA", "В покраску", 49, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OTK", "В ОТК", 30, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KONTROL_SBORKA", "Контрольная сборка", 103, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKLAD", "На склад", 41, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MATERIAL_SKLAD", "Материалы на склад", 97, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpCategory.Properties.DataSource = this.BindSourceCategory;
            this.lookUpCategory.Properties.DisplayMember = "CATEGORY_NAME";
            this.lookUpCategory.Properties.ValueMember = "CATEGORY_ID";
            this.lookUpCategory.Size = new System.Drawing.Size(270, 23);
            this.lookUpCategory.TabIndex = 16;
            this.lookUpCategory.EditValueChanged += new System.EventHandler(this.lookUpCategory_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.Image")));
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.Location = new System.Drawing.Point(12, 224);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(156, 23);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "ОТК";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl8.Appearance.Image")));
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl8.Location = new System.Drawing.Point(12, 253);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(156, 23);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Контрольная сборка";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl9.Appearance.Image")));
            this.labelControl9.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl9.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl9.Location = new System.Drawing.Point(12, 282);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(156, 23);
            this.labelControl9.TabIndex = 33;
            this.labelControl9.Text = "Приход на склад";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl10.Appearance.Image")));
            this.labelControl10.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl10.Location = new System.Drawing.Point(12, 311);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(156, 23);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Материалы на склад";
            // 
            // txtOtk
            // 
            this.txtOtk.EditValue = "";
            this.txtOtk.Location = new System.Drawing.Point(174, 225);
            this.txtOtk.Name = "txtOtk";
            this.txtOtk.Properties.AutoHeight = false;
            this.txtOtk.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtOtk.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOtk.Properties.EditFormat.FormatString = "{n0}";
            this.txtOtk.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOtk.Properties.Mask.EditMask = "d";
            this.txtOtk.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOtk.Size = new System.Drawing.Size(52, 23);
            this.txtOtk.TabIndex = 35;
            // 
            // txtKontrolSbor
            // 
            this.txtKontrolSbor.EditValue = "";
            this.txtKontrolSbor.Location = new System.Drawing.Point(174, 254);
            this.txtKontrolSbor.Name = "txtKontrolSbor";
            this.txtKontrolSbor.Properties.AutoHeight = false;
            this.txtKontrolSbor.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtKontrolSbor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKontrolSbor.Properties.EditFormat.FormatString = "{n0}";
            this.txtKontrolSbor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKontrolSbor.Properties.Mask.EditMask = "d";
            this.txtKontrolSbor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKontrolSbor.Size = new System.Drawing.Size(52, 23);
            this.txtKontrolSbor.TabIndex = 36;
            // 
            // txtPrihodSklad
            // 
            this.txtPrihodSklad.EditValue = "";
            this.txtPrihodSklad.Location = new System.Drawing.Point(174, 282);
            this.txtPrihodSklad.Name = "txtPrihodSklad";
            this.txtPrihodSklad.Properties.AutoHeight = false;
            this.txtPrihodSklad.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtPrihodSklad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrihodSklad.Properties.EditFormat.FormatString = "{n0}";
            this.txtPrihodSklad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrihodSklad.Properties.Mask.EditMask = "d";
            this.txtPrihodSklad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrihodSklad.Size = new System.Drawing.Size(52, 23);
            this.txtPrihodSklad.TabIndex = 37;
            // 
            // txtMaterialSklad
            // 
            this.txtMaterialSklad.EditValue = "";
            this.txtMaterialSklad.Location = new System.Drawing.Point(174, 311);
            this.txtMaterialSklad.Name = "txtMaterialSklad";
            this.txtMaterialSklad.Properties.AutoHeight = false;
            this.txtMaterialSklad.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtMaterialSklad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMaterialSklad.Properties.EditFormat.FormatString = "{n0}";
            this.txtMaterialSklad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMaterialSklad.Properties.Mask.EditMask = "d";
            this.txtMaterialSklad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMaterialSklad.Size = new System.Drawing.Size(52, 23);
            this.txtMaterialSklad.TabIndex = 38;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl11.Appearance.Image")));
            this.labelControl11.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl11.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl11.Location = new System.Drawing.Point(12, 50);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(156, 23);
            this.labelControl11.TabIndex = 39;
            this.labelControl11.Text = "Категория сложности";
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.EditValue = "";
            this.txtCategory.Location = new System.Drawing.Point(174, 50);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Properties.AutoHeight = false;
            this.txtCategory.Size = new System.Drawing.Size(270, 23);
            this.txtCategory.TabIndex = 40;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl12.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl12.Location = new System.Drawing.Point(232, 79);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(65, 23);
            this.labelControl12.TabIndex = 41;
            this.labelControl12.Text = "дней";
            // 
            // frmCategorSlogn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 404);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtMaterialSklad);
            this.Controls.Add(this.txtPrihodSklad);
            this.Controls.Add(this.txtKontrolSbor);
            this.Controls.Add(this.txtOtk);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnDelClient);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtKraska);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSnabgenie);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCeh);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtOtgruz);
            this.Controls.Add(this.txtTehnolog);
            this.Controls.Add(this.lookUpCategory);
            this.Name = "frmCategorSlogn";
            this.Text = "Категории сложности исполнения";
            this.Load += new System.EventHandler(this.frmCategorSlogn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKraska.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnabgenie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCeh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtgruz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSourceCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTehnolog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKontrolSbor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrihodSklad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialSklad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelClient;
        private DevExpress.XtraEditors.SimpleButton btnSaveClient;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKraska;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSnabgenie;
        private DevExpress.XtraEditors.LabelControl lblClientId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCeh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtOtgruz;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataCategory;
        private System.Windows.Forms.BindingSource BindSourceCategory;
        private DevExpress.XtraEditors.TextEdit txtTehnolog;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtOtk;
        private DevExpress.XtraEditors.TextEdit txtKontrolSbor;
        private DevExpress.XtraEditors.TextEdit txtPrihodSklad;
        private DevExpress.XtraEditors.TextEdit txtMaterialSklad;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtCategory;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}