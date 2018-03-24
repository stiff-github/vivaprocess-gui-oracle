namespace vivaprocess
{
    partial class frmReklamac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReklamac));
            this.sqlKuhni = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.bindKuhni = new System.Windows.Forms.BindingSource(this.components);
            this.lblZakaz = new DevExpress.XtraEditors.LabelControl();
            this.lookUpKuhni = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.dateViewZakaz = new DevExpress.XtraEditors.DateEdit();
            this.btnDelRek = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveRek = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtClient = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRekDescr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOutDescr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRek = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtZakaz = new DevExpress.XtraEditors.TextEdit();
            this.dateRekIn = new DevExpress.XtraEditors.DateEdit();
            this.txtZakazC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtOtdel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtVin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateRekPlan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dateRekFakt = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtStoim = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bindKuhni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKuhni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateViewZakaz.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateViewZakaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRekDescr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutDescr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekIn.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakazC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtdel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekPlan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekFakt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekFakt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlKuhni
            // 
            this.sqlKuhni.ConnectionName = "moderndb_ora";
            this.sqlKuhni.Name = "sqlKuhni";
            // 
            // lblZakaz
            // 
            this.lblZakaz.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblZakaz.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblZakaz.Appearance.Image")));
            this.lblZakaz.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZakaz.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblZakaz.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblZakaz.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblZakaz.Location = new System.Drawing.Point(6, 12);
            this.lblZakaz.Name = "lblZakaz";
            this.lblZakaz.Size = new System.Drawing.Size(102, 23);
            this.lblZakaz.TabIndex = 20;
            this.lblZakaz.Text = "Рекламации";
            // 
            // lookUpKuhni
            // 
            this.lookUpKuhni.Location = new System.Drawing.Point(114, 12);
            this.lookUpKuhni.Name = "lookUpKuhni";
            this.lookUpKuhni.Properties.AutoHeight = false;
            this.lookUpKuhni.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpKuhni.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lookUpKuhni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpKuhni.Properties.DisplayFormat.FormatString = "n0";
            this.lookUpKuhni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lookUpKuhni.Properties.EditFormat.FormatString = "n0";
            this.lookUpKuhni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lookUpKuhni.Properties.NullText = "";
            this.lookUpKuhni.Properties.ShowNullValuePromptWhenFocused = true;
            this.lookUpKuhni.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpKuhni.Properties.UseReadOnlyAppearance = false;
            this.lookUpKuhni.Size = new System.Drawing.Size(172, 23);
            this.lookUpKuhni.TabIndex = 19;
            this.lookUpKuhni.EditValueChanged += new System.EventHandler(this.lookUpKuhni_EditValueChanged);
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl41.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl41.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl41.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl41.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl41.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl41.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl41.Location = new System.Drawing.Point(292, 12);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(56, 23);
            this.labelControl41.TabIndex = 254;
            this.labelControl41.Text = "период";
            // 
            // dateViewZakaz
            // 
            this.dateViewZakaz.EditValue = null;
            this.dateViewZakaz.Location = new System.Drawing.Point(354, 12);
            this.dateViewZakaz.Name = "dateViewZakaz";
            this.dateViewZakaz.Properties.AutoHeight = false;
            this.dateViewZakaz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateViewZakaz.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateViewZakaz.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateViewZakaz.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateViewZakaz.Size = new System.Drawing.Size(97, 23);
            this.dateViewZakaz.TabIndex = 253;
            this.dateViewZakaz.EditValueChanged += new System.EventHandler(this.dateViewZakaz_EditValueChanged);
            // 
            // btnDelRek
            // 
            this.btnDelRek.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelRek.Appearance.Options.UseFont = true;
            this.btnDelRek.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelRek.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRek.Image")));
            this.btnDelRek.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelRek.Location = new System.Drawing.Point(6, 321);
            this.btnDelRek.Name = "btnDelRek";
            this.btnDelRek.Size = new System.Drawing.Size(111, 39);
            this.btnDelRek.TabIndex = 266;
            this.btnDelRek.Text = "Удалить";
            this.btnDelRek.Click += new System.EventHandler(this.btnDelRek_Click);
            // 
            // btnSaveRek
            // 
            this.btnSaveRek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveRek.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveRek.Appearance.Options.UseFont = true;
            this.btnSaveRek.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSaveRek.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRek.Image")));
            this.btnSaveRek.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveRek.Location = new System.Drawing.Point(525, 321);
            this.btnSaveRek.Name = "btnSaveRek";
            this.btnSaveRek.Size = new System.Drawing.Size(111, 39);
            this.btnSaveRek.TabIndex = 265;
            this.btnSaveRek.Text = "Сохранить";
            this.btnSaveRek.Click += new System.EventHandler(this.btnSaveRek_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.Appearance.Image")));
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.Location = new System.Drawing.Point(5, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 23);
            this.labelControl5.TabIndex = 263;
            this.labelControl5.Text = "Клиент";
            // 
            // txtClient
            // 
            this.txtClient.EditValue = "";
            this.txtClient.Location = new System.Drawing.Point(139, 80);
            this.txtClient.Name = "txtClient";
            this.txtClient.Properties.AutoHeight = false;
            this.txtClient.Properties.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(355, 23);
            this.txtClient.TabIndex = 264;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.Appearance.Image")));
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.Location = new System.Drawing.Point(5, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(128, 23);
            this.labelControl4.TabIndex = 261;
            this.labelControl4.Text = "Описание";
            // 
            // txtRekDescr
            // 
            this.txtRekDescr.EditValue = "";
            this.txtRekDescr.Location = new System.Drawing.Point(139, 138);
            this.txtRekDescr.Name = "txtRekDescr";
            this.txtRekDescr.Properties.AutoHeight = false;
            this.txtRekDescr.Size = new System.Drawing.Size(497, 23);
            this.txtRekDescr.TabIndex = 262;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.Appearance.Image")));
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(5, 253);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 23);
            this.labelControl3.TabIndex = 259;
            this.labelControl3.Text = "Примечания";
            // 
            // txtOutDescr
            // 
            this.txtOutDescr.EditValue = "";
            this.txtOutDescr.Location = new System.Drawing.Point(5, 282);
            this.txtOutDescr.Name = "txtOutDescr";
            this.txtOutDescr.Properties.AutoHeight = false;
            this.txtOutDescr.Size = new System.Drawing.Size(631, 23);
            this.txtOutDescr.TabIndex = 260;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.Appearance.Image")));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(5, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 23);
            this.labelControl2.TabIndex = 257;
            this.labelControl2.Text = "Имя рекламации";
            // 
            // txtRek
            // 
            this.txtRek.EditValue = "";
            this.txtRek.Location = new System.Drawing.Point(139, 109);
            this.txtRek.Name = "txtRek";
            this.txtRek.Properties.AutoHeight = false;
            this.txtRek.Size = new System.Drawing.Size(355, 23);
            this.txtRek.TabIndex = 258;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(5, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 23);
            this.labelControl1.TabIndex = 255;
            this.labelControl1.Text = "№№ заказа";
            // 
            // txtZakaz
            // 
            this.txtZakaz.EditValue = "";
            this.txtZakaz.Location = new System.Drawing.Point(139, 51);
            this.txtZakaz.Name = "txtZakaz";
            this.txtZakaz.Properties.AutoHeight = false;
            this.txtZakaz.Properties.DisplayFormat.FormatString = "{n0}";
            this.txtZakaz.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtZakaz.Properties.EditFormat.FormatString = "{n0}";
            this.txtZakaz.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtZakaz.Properties.ReadOnly = true;
            this.txtZakaz.Size = new System.Drawing.Size(130, 23);
            this.txtZakaz.TabIndex = 256;
            // 
            // dateRekIn
            // 
            this.dateRekIn.EditValue = null;
            this.dateRekIn.Location = new System.Drawing.Point(556, 81);
            this.dateRekIn.Name = "dateRekIn";
            this.dateRekIn.Properties.AutoHeight = false;
            this.dateRekIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRekIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRekIn.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateRekIn.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateRekIn.Size = new System.Drawing.Size(80, 23);
            this.dateRekIn.TabIndex = 267;
            // 
            // txtZakazC
            // 
            this.txtZakazC.EditValue = "";
            this.txtZakazC.Location = new System.Drawing.Point(275, 51);
            this.txtZakazC.Name = "txtZakazC";
            this.txtZakazC.Properties.AutoHeight = false;
            this.txtZakazC.Properties.ReadOnly = true;
            this.txtZakazC.Size = new System.Drawing.Size(219, 23);
            this.txtZakazC.TabIndex = 268;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl6.Appearance.Image")));
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl6.Location = new System.Drawing.Point(500, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(136, 23);
            this.labelControl6.TabIndex = 269;
            this.labelControl6.Text = "Дата поступления";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl7.Appearance.Image")));
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.Location = new System.Drawing.Point(5, 166);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(128, 23);
            this.labelControl7.TabIndex = 270;
            this.labelControl7.Text = "Отдел";
            // 
            // txtOtdel
            // 
            this.txtOtdel.EditValue = "";
            this.txtOtdel.Location = new System.Drawing.Point(139, 167);
            this.txtOtdel.Name = "txtOtdel";
            this.txtOtdel.Properties.AutoHeight = false;
            this.txtOtdel.Size = new System.Drawing.Size(209, 23);
            this.txtOtdel.TabIndex = 271;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl8.Appearance.Image")));
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl8.Location = new System.Drawing.Point(354, 167);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 23);
            this.labelControl8.TabIndex = 272;
            this.labelControl8.Text = "Виновник";
            // 
            // txtVin
            // 
            this.txtVin.EditValue = "";
            this.txtVin.Location = new System.Drawing.Point(449, 166);
            this.txtVin.Name = "txtVin";
            this.txtVin.Properties.AutoHeight = false;
            this.txtVin.Size = new System.Drawing.Size(187, 23);
            this.txtVin.TabIndex = 273;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl9.Appearance.Image")));
            this.labelControl9.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl9.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl9.Location = new System.Drawing.Point(5, 195);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(128, 23);
            this.labelControl9.TabIndex = 275;
            this.labelControl9.Text = "План исполнения";
            // 
            // dateRekPlan
            // 
            this.dateRekPlan.EditValue = null;
            this.dateRekPlan.Location = new System.Drawing.Point(53, 224);
            this.dateRekPlan.Name = "dateRekPlan";
            this.dateRekPlan.Properties.AutoHeight = false;
            this.dateRekPlan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRekPlan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRekPlan.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateRekPlan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateRekPlan.Size = new System.Drawing.Size(80, 23);
            this.dateRekPlan.TabIndex = 274;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl10.Appearance.Image")));
            this.labelControl10.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl10.Location = new System.Drawing.Point(500, 195);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(136, 23);
            this.labelControl10.TabIndex = 277;
            this.labelControl10.Text = "Факт исполнения";
            // 
            // dateRekFakt
            // 
            this.dateRekFakt.EditValue = null;
            this.dateRekFakt.Location = new System.Drawing.Point(556, 226);
            this.dateRekFakt.Name = "dateRekFakt";
            this.dateRekFakt.Properties.AutoHeight = false;
            this.dateRekFakt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRekFakt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRekFakt.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateRekFakt.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateRekFakt.Size = new System.Drawing.Size(80, 23);
            this.dateRekFakt.TabIndex = 276;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl11.Appearance.Image")));
            this.labelControl11.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl11.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl11.Location = new System.Drawing.Point(139, 196);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(89, 23);
            this.labelControl11.TabIndex = 278;
            this.labelControl11.Text = "Стоимость";
            // 
            // txtStoim
            // 
            this.txtStoim.EditValue = "0";
            this.txtStoim.Location = new System.Drawing.Point(231, 196);
            this.txtStoim.Name = "txtStoim";
            this.txtStoim.Properties.Appearance.Options.UseTextOptions = true;
            this.txtStoim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtStoim.Properties.AutoHeight = false;
            this.txtStoim.Properties.Mask.EditMask = "n";
            this.txtStoim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtStoim.Size = new System.Drawing.Size(71, 23);
            this.txtStoim.TabIndex = 280;
            // 
            // frmReklamac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 375);
            this.Controls.Add(this.txtStoim);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.dateRekFakt);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dateRekPlan);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtOtdel);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtZakazC);
            this.Controls.Add(this.dateRekIn);
            this.Controls.Add(this.btnDelRek);
            this.Controls.Add(this.btnSaveRek);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtRekDescr);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtOutDescr);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtRek);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtZakaz);
            this.Controls.Add(this.labelControl41);
            this.Controls.Add(this.dateViewZakaz);
            this.Controls.Add(this.lblZakaz);
            this.Controls.Add(this.lookUpKuhni);
            this.Name = "frmReklamac";
            this.Text = "Рекламации по заказам";
            this.Load += new System.EventHandler(this.frmReklamac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindKuhni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKuhni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateViewZakaz.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateViewZakaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRekDescr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutDescr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekIn.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZakazC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtdel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekPlan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekFakt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRekFakt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoim.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlKuhni;
        private System.Windows.Forms.BindingSource bindKuhni;
        private DevExpress.XtraEditors.LabelControl lblZakaz;
        private DevExpress.XtraEditors.LookUpEdit lookUpKuhni;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.DateEdit dateViewZakaz;
        private DevExpress.XtraEditors.SimpleButton btnDelRek;
        private DevExpress.XtraEditors.SimpleButton btnSaveRek;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtClient;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRekDescr;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOutDescr;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtRek;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtZakaz;
        private DevExpress.XtraEditors.DateEdit dateRekIn;
        private DevExpress.XtraEditors.TextEdit txtZakazC;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtOtdel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtVin;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dateRekPlan;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dateRekFakt;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtStoim;
    }
}