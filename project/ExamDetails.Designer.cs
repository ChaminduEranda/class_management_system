namespace project
{
    partial class frmExamDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.AddExam = new MetroFramework.Controls.MetroTabPage();
            this.dobPicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.error_msgEX = new System.Windows.Forms.Label();
            this.btnExClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnExCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ExName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ExId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateExam = new MetroFramework.Controls.MetroTabPage();
            this.dobPicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.error_msgEX_Up = new System.Windows.Forms.Label();
            this.btnExUpClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnExUpCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ExName_Up = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ExId_Up = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteExam = new MetroFramework.Controls.MetroTabPage();
            this.error_msgEX_Del = new System.Windows.Forms.Label();
            this.btnExDelClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnExDelCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Ex_Delete = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewExam = new MetroFramework.Controls.MetroTabPage();
            this.btnExView_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExView = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Ex_View = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.rbt_ExName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbt_ExId = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mini = new Guna.UI2.WinForms.Guna2Button();
            this.btn_maxi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cls = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.AddExam.SuspendLayout();
            this.UpdateExam.SuspendLayout();
            this.DeleteExam.SuspendLayout();
            this.ViewExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.AddExam);
            this.metroTabControl1.Controls.Add(this.UpdateExam);
            this.metroTabControl1.Controls.Add(this.DeleteExam);
            this.metroTabControl1.Controls.Add(this.ViewExam);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 85);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(867, 660);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // AddExam
            // 
            this.AddExam.BackColor = System.Drawing.Color.PeachPuff;
            this.AddExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddExam.BackgroundImage")));
            this.AddExam.Controls.Add(this.dobPicker1);
            this.AddExam.Controls.Add(this.error_msgEX);
            this.AddExam.Controls.Add(this.btnExClear);
            this.AddExam.Controls.Add(this.btnExCancel);
            this.AddExam.Controls.Add(this.btnExAdd);
            this.AddExam.Controls.Add(this.guna2HtmlLabel8);
            this.AddExam.Controls.Add(this.txt_ExName);
            this.AddExam.Controls.Add(this.guna2HtmlLabel9);
            this.AddExam.Controls.Add(this.txt_ExId);
            this.AddExam.Controls.Add(this.guna2HtmlLabel10);
            this.AddExam.Controls.Add(this.label1);
            this.AddExam.HorizontalScrollbarBarColor = true;
            this.AddExam.HorizontalScrollbarHighlightOnWheel = false;
            this.AddExam.HorizontalScrollbarSize = 12;
            this.AddExam.Location = new System.Drawing.Point(4, 38);
            this.AddExam.Margin = new System.Windows.Forms.Padding(4);
            this.AddExam.Name = "AddExam";
            this.AddExam.Size = new System.Drawing.Size(859, 618);
            this.AddExam.TabIndex = 0;
            this.AddExam.Text = "ADD";
            this.AddExam.UseCustomBackColor = true;
            this.AddExam.UseCustomForeColor = true;
            this.AddExam.UseStyleColors = true;
            this.AddExam.UseVisualStyleBackColor = true;
            this.AddExam.VerticalScrollbar = true;
            this.AddExam.VerticalScrollbarBarColor = true;
            this.AddExam.VerticalScrollbarHighlightOnWheel = false;
            this.AddExam.VerticalScrollbarSize = 13;
            // 
            // dobPicker1
            // 
            this.dobPicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobPicker1.BackColor = System.Drawing.Color.White;
            this.dobPicker1.CheckedState.Parent = this.dobPicker1;
            this.dobPicker1.FillColor = System.Drawing.Color.White;
            this.dobPicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dobPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobPicker1.HoverState.Parent = this.dobPicker1;
            this.dobPicker1.Location = new System.Drawing.Point(351, 312);
            this.dobPicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobPicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobPicker1.Name = "dobPicker1";
            this.dobPicker1.ShadowDecoration.Parent = this.dobPicker1;
            this.dobPicker1.Size = new System.Drawing.Size(223, 40);
            this.dobPicker1.TabIndex = 94;
            this.dobPicker1.Value = new System.DateTime(2021, 7, 10, 23, 32, 0, 284);
            // 
            // error_msgEX
            // 
            this.error_msgEX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.error_msgEX.AutoSize = true;
            this.error_msgEX.BackColor = System.Drawing.Color.Transparent;
            this.error_msgEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msgEX.ForeColor = System.Drawing.Color.Red;
            this.error_msgEX.Location = new System.Drawing.Point(220, 574);
            this.error_msgEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_msgEX.Name = "error_msgEX";
            this.error_msgEX.Size = new System.Drawing.Size(0, 20);
            this.error_msgEX.TabIndex = 93;
            this.error_msgEX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.error_msgEX.UseWaitCursor = true;
            // 
            // btnExClear
            // 
            this.btnExClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExClear.CheckedState.Parent = this.btnExClear;
            this.btnExClear.CustomImages.Parent = this.btnExClear;
            this.btnExClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExClear.DisabledState.Parent = this.btnExClear;
            this.btnExClear.FillColor = System.Drawing.Color.Coral;
            this.btnExClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExClear.ForeColor = System.Drawing.Color.White;
            this.btnExClear.HoverState.Parent = this.btnExClear;
            this.btnExClear.Location = new System.Drawing.Point(369, 501);
            this.btnExClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnExClear.Name = "btnExClear";
            this.btnExClear.ShadowDecoration.Parent = this.btnExClear;
            this.btnExClear.Size = new System.Drawing.Size(155, 42);
            this.btnExClear.TabIndex = 92;
            this.btnExClear.Text = "Clear";
            this.btnExClear.UseWaitCursor = true;
            this.btnExClear.Click += new System.EventHandler(this.btnExClear_Click);
            // 
            // btnExCancel
            // 
            this.btnExCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExCancel.CheckedState.Parent = this.btnExCancel;
            this.btnExCancel.CustomImages.Parent = this.btnExCancel;
            this.btnExCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExCancel.DisabledState.Parent = this.btnExCancel;
            this.btnExCancel.FillColor = System.Drawing.Color.Coral;
            this.btnExCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExCancel.ForeColor = System.Drawing.Color.White;
            this.btnExCancel.HoverState.Parent = this.btnExCancel;
            this.btnExCancel.Location = new System.Drawing.Point(601, 501);
            this.btnExCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExCancel.Name = "btnExCancel";
            this.btnExCancel.ShadowDecoration.Parent = this.btnExCancel;
            this.btnExCancel.Size = new System.Drawing.Size(155, 42);
            this.btnExCancel.TabIndex = 91;
            this.btnExCancel.Text = "Cancel";
            this.btnExCancel.UseWaitCursor = true;
            this.btnExCancel.Click += new System.EventHandler(this.btnExCancel_Click);
            // 
            // btnExAdd
            // 
            this.btnExAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExAdd.CheckedState.Parent = this.btnExAdd;
            this.btnExAdd.CustomImages.Parent = this.btnExAdd;
            this.btnExAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExAdd.DisabledState.Parent = this.btnExAdd;
            this.btnExAdd.FillColor = System.Drawing.Color.Coral;
            this.btnExAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExAdd.ForeColor = System.Drawing.Color.White;
            this.btnExAdd.HoverState.Parent = this.btnExAdd;
            this.btnExAdd.Location = new System.Drawing.Point(129, 501);
            this.btnExAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnExAdd.Name = "btnExAdd";
            this.btnExAdd.ShadowDecoration.Parent = this.btnExAdd;
            this.btnExAdd.Size = new System.Drawing.Size(155, 42);
            this.btnExAdd.TabIndex = 90;
            this.btnExAdd.Text = "Add";
            this.btnExAdd.UseWaitCursor = true;
            this.btnExAdd.Click += new System.EventHandler(this.btnExAdd_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(167, 322);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(145, 26);
            this.guna2HtmlLabel8.TabIndex = 86;
            this.guna2HtmlLabel8.Text = "Date:";
            this.guna2HtmlLabel8.UseWaitCursor = true;
            // 
            // txt_ExName
            // 
            this.txt_ExName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ExName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_ExName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_ExName.DefaultText = "";
            this.txt_ExName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ExName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ExName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExName.DisabledState.Parent = this.txt_ExName;
            this.txt_ExName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExName.FocusedState.Parent = this.txt_ExName;
            this.txt_ExName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExName.ForeColor = System.Drawing.Color.Black;
            this.txt_ExName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExName.HoverState.Parent = this.txt_ExName;
            this.txt_ExName.Location = new System.Drawing.Point(351, 209);
            this.txt_ExName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExName.Name = "txt_ExName";
            this.txt_ExName.PasswordChar = '\0';
            this.txt_ExName.PlaceholderText = "";
            this.txt_ExName.SelectedText = "";
            this.txt_ExName.ShadowDecoration.Parent = this.txt_ExName;
            this.txt_ExName.Size = new System.Drawing.Size(224, 39);
            this.txt_ExName.TabIndex = 85;
            this.txt_ExName.UseWaitCursor = true;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(167, 218);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(135, 26);
            this.guna2HtmlLabel9.TabIndex = 84;
            this.guna2HtmlLabel9.Text = "Name:";
            this.guna2HtmlLabel9.UseWaitCursor = true;
            // 
            // txt_ExId
            // 
            this.txt_ExId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ExId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_ExId.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_ExId.DefaultText = "";
            this.txt_ExId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ExId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ExId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExId.DisabledState.Parent = this.txt_ExId;
            this.txt_ExId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExId.FocusedState.Parent = this.txt_ExId;
            this.txt_ExId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExId.ForeColor = System.Drawing.Color.Black;
            this.txt_ExId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExId.HoverState.Parent = this.txt_ExId;
            this.txt_ExId.Location = new System.Drawing.Point(351, 107);
            this.txt_ExId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExId.Name = "txt_ExId";
            this.txt_ExId.PasswordChar = '\0';
            this.txt_ExId.PlaceholderText = "";
            this.txt_ExId.SelectedText = "";
            this.txt_ExId.ShadowDecoration.Parent = this.txt_ExId;
            this.txt_ExId.Size = new System.Drawing.Size(224, 39);
            this.txt_ExId.TabIndex = 83;
            this.txt_ExId.UseWaitCursor = true;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(167, 116);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(175, 26);
            this.guna2HtmlLabel10.TabIndex = 82;
            this.guna2HtmlLabel10.Text = "Exam Id:";
            this.guna2HtmlLabel10.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(336, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 81;
            this.label1.Text = "ADD Exam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // UpdateExam
            // 
            this.UpdateExam.BackColor = System.Drawing.Color.PeachPuff;
            this.UpdateExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateExam.BackgroundImage")));
            this.UpdateExam.Controls.Add(this.dobPicker2);
            this.UpdateExam.Controls.Add(this.error_msgEX_Up);
            this.UpdateExam.Controls.Add(this.btnExUpClear);
            this.UpdateExam.Controls.Add(this.btnExUpCancel);
            this.UpdateExam.Controls.Add(this.btnExUpdate);
            this.UpdateExam.Controls.Add(this.guna2HtmlLabel2);
            this.UpdateExam.Controls.Add(this.txt_ExName_Up);
            this.UpdateExam.Controls.Add(this.guna2HtmlLabel3);
            this.UpdateExam.Controls.Add(this.txt_ExId_Up);
            this.UpdateExam.Controls.Add(this.guna2HtmlLabel4);
            this.UpdateExam.Controls.Add(this.label2);
            this.UpdateExam.HorizontalScrollbarBarColor = true;
            this.UpdateExam.HorizontalScrollbarHighlightOnWheel = false;
            this.UpdateExam.HorizontalScrollbarSize = 12;
            this.UpdateExam.Location = new System.Drawing.Point(4, 38);
            this.UpdateExam.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateExam.Name = "UpdateExam";
            this.UpdateExam.Size = new System.Drawing.Size(859, 618);
            this.UpdateExam.TabIndex = 1;
            this.UpdateExam.Text = "UPDATE";
            this.UpdateExam.UseCustomBackColor = true;
            this.UpdateExam.UseCustomForeColor = true;
            this.UpdateExam.UseStyleColors = true;
            this.UpdateExam.UseVisualStyleBackColor = true;
            this.UpdateExam.VerticalScrollbar = true;
            this.UpdateExam.VerticalScrollbarBarColor = true;
            this.UpdateExam.VerticalScrollbarHighlightOnWheel = false;
            this.UpdateExam.VerticalScrollbarSize = 13;
            // 
            // dobPicker2
            // 
            this.dobPicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobPicker2.BackColor = System.Drawing.Color.White;
            this.dobPicker2.CheckedState.Parent = this.dobPicker2;
            this.dobPicker2.FillColor = System.Drawing.Color.White;
            this.dobPicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dobPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobPicker2.HoverState.Parent = this.dobPicker2;
            this.dobPicker2.Location = new System.Drawing.Point(378, 318);
            this.dobPicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobPicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobPicker2.Name = "dobPicker2";
            this.dobPicker2.ShadowDecoration.Parent = this.dobPicker2;
            this.dobPicker2.Size = new System.Drawing.Size(224, 40);
            this.dobPicker2.TabIndex = 103;
            this.dobPicker2.Value = new System.DateTime(2021, 7, 10, 23, 32, 0, 284);
            // 
            // error_msgEX_Up
            // 
            this.error_msgEX_Up.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.error_msgEX_Up.AutoSize = true;
            this.error_msgEX_Up.BackColor = System.Drawing.Color.Transparent;
            this.error_msgEX_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msgEX_Up.ForeColor = System.Drawing.Color.Red;
            this.error_msgEX_Up.Location = new System.Drawing.Point(220, 575);
            this.error_msgEX_Up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_msgEX_Up.Name = "error_msgEX_Up";
            this.error_msgEX_Up.Size = new System.Drawing.Size(0, 20);
            this.error_msgEX_Up.TabIndex = 102;
            this.error_msgEX_Up.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnExUpClear
            // 
            this.btnExUpClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExUpClear.CheckedState.Parent = this.btnExUpClear;
            this.btnExUpClear.CustomImages.Parent = this.btnExUpClear;
            this.btnExUpClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExUpClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExUpClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExUpClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExUpClear.DisabledState.Parent = this.btnExUpClear;
            this.btnExUpClear.FillColor = System.Drawing.Color.Coral;
            this.btnExUpClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExUpClear.ForeColor = System.Drawing.Color.White;
            this.btnExUpClear.HoverState.Parent = this.btnExUpClear;
            this.btnExUpClear.Location = new System.Drawing.Point(359, 503);
            this.btnExUpClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnExUpClear.Name = "btnExUpClear";
            this.btnExUpClear.ShadowDecoration.Parent = this.btnExUpClear;
            this.btnExUpClear.Size = new System.Drawing.Size(155, 42);
            this.btnExUpClear.TabIndex = 101;
            this.btnExUpClear.Text = "Clear";
            this.btnExUpClear.Click += new System.EventHandler(this.btnExUpClear_Click);
            // 
            // btnExUpCancel
            // 
            this.btnExUpCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExUpCancel.CheckedState.Parent = this.btnExUpCancel;
            this.btnExUpCancel.CustomImages.Parent = this.btnExUpCancel;
            this.btnExUpCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExUpCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExUpCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExUpCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExUpCancel.DisabledState.Parent = this.btnExUpCancel;
            this.btnExUpCancel.FillColor = System.Drawing.Color.Coral;
            this.btnExUpCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExUpCancel.ForeColor = System.Drawing.Color.White;
            this.btnExUpCancel.HoverState.Parent = this.btnExUpCancel;
            this.btnExUpCancel.Location = new System.Drawing.Point(591, 503);
            this.btnExUpCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExUpCancel.Name = "btnExUpCancel";
            this.btnExUpCancel.ShadowDecoration.Parent = this.btnExUpCancel;
            this.btnExUpCancel.Size = new System.Drawing.Size(155, 42);
            this.btnExUpCancel.TabIndex = 100;
            this.btnExUpCancel.Text = "Cancel";
            this.btnExUpCancel.Click += new System.EventHandler(this.btnExUpCancel_Click);
            // 
            // btnExUpdate
            // 
            this.btnExUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExUpdate.CheckedState.Parent = this.btnExUpdate;
            this.btnExUpdate.CustomImages.Parent = this.btnExUpdate;
            this.btnExUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExUpdate.DisabledState.Parent = this.btnExUpdate;
            this.btnExUpdate.FillColor = System.Drawing.Color.Coral;
            this.btnExUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExUpdate.ForeColor = System.Drawing.Color.White;
            this.btnExUpdate.HoverState.Parent = this.btnExUpdate;
            this.btnExUpdate.Location = new System.Drawing.Point(119, 503);
            this.btnExUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnExUpdate.Name = "btnExUpdate";
            this.btnExUpdate.ShadowDecoration.Parent = this.btnExUpdate;
            this.btnExUpdate.Size = new System.Drawing.Size(155, 42);
            this.btnExUpdate.TabIndex = 99;
            this.btnExUpdate.Text = "Update";
            this.btnExUpdate.Click += new System.EventHandler(this.btnExUpdate_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(197, 322);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(132, 26);
            this.guna2HtmlLabel2.TabIndex = 95;
            this.guna2HtmlLabel2.Text = "Date:";
            // 
            // txt_ExName_Up
            // 
            this.txt_ExName_Up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ExName_Up.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_ExName_Up.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_ExName_Up.DefaultText = "";
            this.txt_ExName_Up.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ExName_Up.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ExName_Up.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExName_Up.DisabledState.Parent = this.txt_ExName_Up;
            this.txt_ExName_Up.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExName_Up.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExName_Up.FocusedState.Parent = this.txt_ExName_Up;
            this.txt_ExName_Up.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExName_Up.ForeColor = System.Drawing.Color.Black;
            this.txt_ExName_Up.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExName_Up.HoverState.Parent = this.txt_ExName_Up;
            this.txt_ExName_Up.Location = new System.Drawing.Point(378, 220);
            this.txt_ExName_Up.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExName_Up.Name = "txt_ExName_Up";
            this.txt_ExName_Up.PasswordChar = '\0';
            this.txt_ExName_Up.PlaceholderText = "";
            this.txt_ExName_Up.SelectedText = "";
            this.txt_ExName_Up.ShadowDecoration.Parent = this.txt_ExName_Up;
            this.txt_ExName_Up.Size = new System.Drawing.Size(224, 39);
            this.txt_ExName_Up.TabIndex = 94;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(197, 226);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(144, 26);
            this.guna2HtmlLabel3.TabIndex = 93;
            this.guna2HtmlLabel3.Text = "Name:";
            // 
            // txt_ExId_Up
            // 
            this.txt_ExId_Up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ExId_Up.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_ExId_Up.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_ExId_Up.DefaultText = "";
            this.txt_ExId_Up.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ExId_Up.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ExId_Up.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExId_Up.DisabledState.Parent = this.txt_ExId_Up;
            this.txt_ExId_Up.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExId_Up.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExId_Up.FocusedState.Parent = this.txt_ExId_Up;
            this.txt_ExId_Up.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExId_Up.ForeColor = System.Drawing.Color.Black;
            this.txt_ExId_Up.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExId_Up.HoverState.Parent = this.txt_ExId_Up;
            this.txt_ExId_Up.Location = new System.Drawing.Point(378, 117);
            this.txt_ExId_Up.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExId_Up.Name = "txt_ExId_Up";
            this.txt_ExId_Up.PasswordChar = '\0';
            this.txt_ExId_Up.PlaceholderText = "";
            this.txt_ExId_Up.SelectedText = "";
            this.txt_ExId_Up.ShadowDecoration.Parent = this.txt_ExId_Up;
            this.txt_ExId_Up.Size = new System.Drawing.Size(224, 39);
            this.txt_ExId_Up.TabIndex = 92;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(197, 123);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(163, 26);
            this.guna2HtmlLabel4.TabIndex = 91;
            this.guna2HtmlLabel4.Text = "Exam Id:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(307, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 40);
            this.label2.TabIndex = 90;
            this.label2.Text = "UPDATE Exam";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteExam
            // 
            this.DeleteExam.BackColor = System.Drawing.Color.PeachPuff;
            this.DeleteExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteExam.BackgroundImage")));
            this.DeleteExam.Controls.Add(this.error_msgEX_Del);
            this.DeleteExam.Controls.Add(this.btnExDelClear);
            this.DeleteExam.Controls.Add(this.btnExDelCancel);
            this.DeleteExam.Controls.Add(this.btnExDelete);
            this.DeleteExam.Controls.Add(this.txt_Ex_Delete);
            this.DeleteExam.Controls.Add(this.guna2HtmlLabel5);
            this.DeleteExam.Controls.Add(this.label3);
            this.DeleteExam.HorizontalScrollbarBarColor = true;
            this.DeleteExam.HorizontalScrollbarHighlightOnWheel = false;
            this.DeleteExam.HorizontalScrollbarSize = 12;
            this.DeleteExam.Location = new System.Drawing.Point(4, 38);
            this.DeleteExam.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteExam.Name = "DeleteExam";
            this.DeleteExam.Size = new System.Drawing.Size(859, 618);
            this.DeleteExam.TabIndex = 2;
            this.DeleteExam.Text = "DELETE";
            this.DeleteExam.UseCustomBackColor = true;
            this.DeleteExam.UseCustomForeColor = true;
            this.DeleteExam.UseStyleColors = true;
            this.DeleteExam.UseVisualStyleBackColor = true;
            this.DeleteExam.VerticalScrollbar = true;
            this.DeleteExam.VerticalScrollbarBarColor = true;
            this.DeleteExam.VerticalScrollbarHighlightOnWheel = false;
            this.DeleteExam.VerticalScrollbarSize = 13;
            // 
            // error_msgEX_Del
            // 
            this.error_msgEX_Del.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.error_msgEX_Del.AutoSize = true;
            this.error_msgEX_Del.BackColor = System.Drawing.Color.Transparent;
            this.error_msgEX_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msgEX_Del.ForeColor = System.Drawing.Color.Red;
            this.error_msgEX_Del.Location = new System.Drawing.Point(220, 575);
            this.error_msgEX_Del.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_msgEX_Del.Name = "error_msgEX_Del";
            this.error_msgEX_Del.Size = new System.Drawing.Size(0, 20);
            this.error_msgEX_Del.TabIndex = 99;
            this.error_msgEX_Del.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.error_msgEX_Del.UseWaitCursor = true;
            // 
            // btnExDelClear
            // 
            this.btnExDelClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExDelClear.CheckedState.Parent = this.btnExDelClear;
            this.btnExDelClear.CustomImages.Parent = this.btnExDelClear;
            this.btnExDelClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExDelClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExDelClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExDelClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExDelClear.DisabledState.Parent = this.btnExDelClear;
            this.btnExDelClear.FillColor = System.Drawing.Color.Coral;
            this.btnExDelClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExDelClear.ForeColor = System.Drawing.Color.White;
            this.btnExDelClear.HoverState.Parent = this.btnExDelClear;
            this.btnExDelClear.Location = new System.Drawing.Point(348, 490);
            this.btnExDelClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnExDelClear.Name = "btnExDelClear";
            this.btnExDelClear.ShadowDecoration.Parent = this.btnExDelClear;
            this.btnExDelClear.Size = new System.Drawing.Size(155, 42);
            this.btnExDelClear.TabIndex = 98;
            this.btnExDelClear.Text = "Clear";
            this.btnExDelClear.UseWaitCursor = true;
            this.btnExDelClear.Click += new System.EventHandler(this.btnExDelClear_Click);
            // 
            // btnExDelCancel
            // 
            this.btnExDelCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExDelCancel.CheckedState.Parent = this.btnExDelCancel;
            this.btnExDelCancel.CustomImages.Parent = this.btnExDelCancel;
            this.btnExDelCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExDelCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExDelCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExDelCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExDelCancel.DisabledState.Parent = this.btnExDelCancel;
            this.btnExDelCancel.FillColor = System.Drawing.Color.Coral;
            this.btnExDelCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExDelCancel.ForeColor = System.Drawing.Color.White;
            this.btnExDelCancel.HoverState.Parent = this.btnExDelCancel;
            this.btnExDelCancel.Location = new System.Drawing.Point(580, 490);
            this.btnExDelCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExDelCancel.Name = "btnExDelCancel";
            this.btnExDelCancel.ShadowDecoration.Parent = this.btnExDelCancel;
            this.btnExDelCancel.Size = new System.Drawing.Size(155, 42);
            this.btnExDelCancel.TabIndex = 97;
            this.btnExDelCancel.Text = "Cancel";
            this.btnExDelCancel.UseWaitCursor = true;
            this.btnExDelCancel.Click += new System.EventHandler(this.btnExDelCancel_Click);
            // 
            // btnExDelete
            // 
            this.btnExDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExDelete.CheckedState.Parent = this.btnExDelete;
            this.btnExDelete.CustomImages.Parent = this.btnExDelete;
            this.btnExDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExDelete.DisabledState.Parent = this.btnExDelete;
            this.btnExDelete.FillColor = System.Drawing.Color.Coral;
            this.btnExDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExDelete.ForeColor = System.Drawing.Color.White;
            this.btnExDelete.HoverState.Parent = this.btnExDelete;
            this.btnExDelete.Location = new System.Drawing.Point(108, 490);
            this.btnExDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnExDelete.Name = "btnExDelete";
            this.btnExDelete.ShadowDecoration.Parent = this.btnExDelete;
            this.btnExDelete.Size = new System.Drawing.Size(155, 42);
            this.btnExDelete.TabIndex = 96;
            this.btnExDelete.Text = "Delete";
            this.btnExDelete.UseWaitCursor = true;
            this.btnExDelete.Click += new System.EventHandler(this.btnExDelete_Click);
            // 
            // txt_Ex_Delete
            // 
            this.txt_Ex_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Ex_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Ex_Delete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Ex_Delete.DefaultText = "";
            this.txt_Ex_Delete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Ex_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Ex_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Ex_Delete.DisabledState.Parent = this.txt_Ex_Delete;
            this.txt_Ex_Delete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Ex_Delete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Ex_Delete.FocusedState.Parent = this.txt_Ex_Delete;
            this.txt_Ex_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ex_Delete.ForeColor = System.Drawing.Color.Black;
            this.txt_Ex_Delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Ex_Delete.HoverState.Parent = this.txt_Ex_Delete;
            this.txt_Ex_Delete.Location = new System.Drawing.Point(325, 143);
            this.txt_Ex_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ex_Delete.Name = "txt_Ex_Delete";
            this.txt_Ex_Delete.PasswordChar = '\0';
            this.txt_Ex_Delete.PlaceholderText = "";
            this.txt_Ex_Delete.SelectedText = "";
            this.txt_Ex_Delete.ShadowDecoration.Parent = this.txt_Ex_Delete;
            this.txt_Ex_Delete.Size = new System.Drawing.Size(224, 39);
            this.txt_Ex_Delete.TabIndex = 95;
            this.txt_Ex_Delete.UseWaitCursor = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(150, 151);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(167, 26);
            this.guna2HtmlLabel5.TabIndex = 94;
            this.guna2HtmlLabel5.Text = "Exam Id:";
            this.guna2HtmlLabel5.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(289, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 40);
            this.label3.TabIndex = 93;
            this.label3.Text = "DELETE Exam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseWaitCursor = true;
            // 
            // ViewExam
            // 
            this.ViewExam.BackColor = System.Drawing.Color.PeachPuff;
            this.ViewExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewExam.BackgroundImage")));
            this.ViewExam.Controls.Add(this.btnExView_Cancel);
            this.ViewExam.Controls.Add(this.btnExView);
            this.ViewExam.Controls.Add(this.txt_Ex_View);
            this.ViewExam.Controls.Add(this.dataGridView1);
            this.ViewExam.Controls.Add(this.rbt_ExName);
            this.ViewExam.Controls.Add(this.rbt_ExId);
            this.ViewExam.HorizontalScrollbarBarColor = true;
            this.ViewExam.HorizontalScrollbarHighlightOnWheel = false;
            this.ViewExam.HorizontalScrollbarSize = 12;
            this.ViewExam.Location = new System.Drawing.Point(4, 38);
            this.ViewExam.Margin = new System.Windows.Forms.Padding(4);
            this.ViewExam.Name = "ViewExam";
            this.ViewExam.Size = new System.Drawing.Size(859, 618);
            this.ViewExam.TabIndex = 3;
            this.ViewExam.Text = "VIEW";
            this.ViewExam.UseCustomBackColor = true;
            this.ViewExam.UseCustomForeColor = true;
            this.ViewExam.UseStyleColors = true;
            this.ViewExam.UseVisualStyleBackColor = true;
            this.ViewExam.VerticalScrollbarBarColor = true;
            this.ViewExam.VerticalScrollbarHighlightOnWheel = false;
            this.ViewExam.VerticalScrollbarSize = 13;
            // 
            // btnExView_Cancel
            // 
            this.btnExView_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExView_Cancel.CheckedState.Parent = this.btnExView_Cancel;
            this.btnExView_Cancel.CustomImages.Parent = this.btnExView_Cancel;
            this.btnExView_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExView_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExView_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExView_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExView_Cancel.DisabledState.Parent = this.btnExView_Cancel;
            this.btnExView_Cancel.FillColor = System.Drawing.Color.Coral;
            this.btnExView_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExView_Cancel.ForeColor = System.Drawing.Color.White;
            this.btnExView_Cancel.HoverState.Parent = this.btnExView_Cancel;
            this.btnExView_Cancel.Location = new System.Drawing.Point(583, 66);
            this.btnExView_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExView_Cancel.Name = "btnExView_Cancel";
            this.btnExView_Cancel.ShadowDecoration.Parent = this.btnExView_Cancel;
            this.btnExView_Cancel.Size = new System.Drawing.Size(155, 42);
            this.btnExView_Cancel.TabIndex = 75;
            this.btnExView_Cancel.Text = "Cancel";
            this.btnExView_Cancel.UseWaitCursor = true;
            this.btnExView_Cancel.Click += new System.EventHandler(this.btnExView_Cancel_Click);
            // 
            // btnExView
            // 
            this.btnExView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExView.CheckedState.Parent = this.btnExView;
            this.btnExView.CustomImages.Parent = this.btnExView;
            this.btnExView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExView.DisabledState.Parent = this.btnExView;
            this.btnExView.FillColor = System.Drawing.Color.Coral;
            this.btnExView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExView.ForeColor = System.Drawing.Color.White;
            this.btnExView.HoverState.Parent = this.btnExView;
            this.btnExView.Location = new System.Drawing.Point(583, 7);
            this.btnExView.Margin = new System.Windows.Forms.Padding(4);
            this.btnExView.Name = "btnExView";
            this.btnExView.ShadowDecoration.Parent = this.btnExView;
            this.btnExView.Size = new System.Drawing.Size(155, 42);
            this.btnExView.TabIndex = 73;
            this.btnExView.Text = "View";
            this.btnExView.UseWaitCursor = true;
            this.btnExView.Click += new System.EventHandler(this.btnExView_Click);
            // 
            // txt_Ex_View
            // 
            this.txt_Ex_View.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Ex_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Ex_View.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Ex_View.DefaultText = "";
            this.txt_Ex_View.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Ex_View.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Ex_View.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Ex_View.DisabledState.Parent = this.txt_Ex_View;
            this.txt_Ex_View.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Ex_View.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Ex_View.FocusedState.Parent = this.txt_Ex_View;
            this.txt_Ex_View.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ex_View.ForeColor = System.Drawing.Color.Black;
            this.txt_Ex_View.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Ex_View.HoverState.Parent = this.txt_Ex_View;
            this.txt_Ex_View.Location = new System.Drawing.Point(260, 36);
            this.txt_Ex_View.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ex_View.Name = "txt_Ex_View";
            this.txt_Ex_View.PasswordChar = '\0';
            this.txt_Ex_View.PlaceholderText = "";
            this.txt_Ex_View.SelectedText = "";
            this.txt_Ex_View.ShadowDecoration.Parent = this.txt_Ex_View;
            this.txt_Ex_View.Size = new System.Drawing.Size(237, 30);
            this.txt_Ex_View.TabIndex = 72;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(7, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 489);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // rbt_ExName
            // 
            this.rbt_ExName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbt_ExName.AutoSize = true;
            this.rbt_ExName.BackColor = System.Drawing.Color.Transparent;
            this.rbt_ExName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbt_ExName.CheckedState.BorderThickness = 0;
            this.rbt_ExName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbt_ExName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbt_ExName.CheckedState.InnerOffset = -4;
            this.rbt_ExName.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ExName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbt_ExName.Location = new System.Drawing.Point(73, 65);
            this.rbt_ExName.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_ExName.Name = "rbt_ExName";
            this.rbt_ExName.Size = new System.Drawing.Size(82, 28);
            this.rbt_ExName.TabIndex = 70;
            this.rbt_ExName.Text = "Name";
            this.rbt_ExName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbt_ExName.UncheckedState.BorderThickness = 2;
            this.rbt_ExName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbt_ExName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbt_ExName.UseVisualStyleBackColor = false;
            this.rbt_ExName.UseWaitCursor = true;
            // 
            // rbt_ExId
            // 
            this.rbt_ExId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbt_ExId.AutoSize = true;
            this.rbt_ExId.BackColor = System.Drawing.Color.Transparent;
            this.rbt_ExId.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbt_ExId.CheckedState.BorderThickness = 0;
            this.rbt_ExId.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbt_ExId.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbt_ExId.CheckedState.InnerOffset = -4;
            this.rbt_ExId.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ExId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbt_ExId.Location = new System.Drawing.Point(73, 11);
            this.rbt_ExId.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_ExId.Name = "rbt_ExId";
            this.rbt_ExId.Size = new System.Drawing.Size(112, 28);
            this.rbt_ExId.TabIndex = 69;
            this.rbt_ExId.Text = "Exam Id ";
            this.rbt_ExId.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbt_ExId.UncheckedState.BorderThickness = 2;
            this.rbt_ExId.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbt_ExId.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbt_ExId.UseVisualStyleBackColor = false;
            this.rbt_ExId.UseWaitCursor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btn_mini);
            this.guna2GradientPanel1.Controls.Add(this.btn_maxi);
            this.guna2GradientPanel1.Controls.Add(this.btn_cls);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(864, 86);
            this.guna2GradientPanel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.BackColor = System.Drawing.Color.White;
            this.btn_mini.CheckedState.Parent = this.btn_mini;
            this.btn_mini.CustomImages.Parent = this.btn_mini;
            this.btn_mini.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_mini.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_mini.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_mini.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_mini.DisabledState.Parent = this.btn_mini;
            this.btn_mini.FillColor = System.Drawing.Color.White;
            this.btn_mini.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mini.ForeColor = System.Drawing.Color.Black;
            this.btn_mini.HoverState.Parent = this.btn_mini;
            this.btn_mini.Location = new System.Drawing.Point(660, 2);
            this.btn_mini.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.ShadowDecoration.Parent = this.btn_mini;
            this.btn_mini.Size = new System.Drawing.Size(61, 46);
            this.btn_mini.TabIndex = 38;
            this.btn_mini.Text = "-";
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_maxi
            // 
            this.btn_maxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maxi.BackColor = System.Drawing.Color.White;
            this.btn_maxi.CheckedState.Parent = this.btn_maxi;
            this.btn_maxi.CustomImages.Parent = this.btn_maxi;
            this.btn_maxi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_maxi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_maxi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_maxi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_maxi.DisabledState.Parent = this.btn_maxi;
            this.btn_maxi.FillColor = System.Drawing.Color.White;
            this.btn_maxi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maxi.ForeColor = System.Drawing.Color.Black;
            this.btn_maxi.HoverState.Parent = this.btn_maxi;
            this.btn_maxi.Location = new System.Drawing.Point(729, 2);
            this.btn_maxi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maxi.Name = "btn_maxi";
            this.btn_maxi.ShadowDecoration.Parent = this.btn_maxi;
            this.btn_maxi.Size = new System.Drawing.Size(61, 46);
            this.btn_maxi.TabIndex = 37;
            this.btn_maxi.Text = "[]";
            this.btn_maxi.Click += new System.EventHandler(this.btn_maxi_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cls.BackColor = System.Drawing.Color.White;
            this.btn_cls.CheckedState.Parent = this.btn_cls;
            this.btn_cls.CustomImages.Parent = this.btn_cls;
            this.btn_cls.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cls.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cls.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cls.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cls.DisabledState.Parent = this.btn_cls;
            this.btn_cls.FillColor = System.Drawing.Color.White;
            this.btn_cls.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.ForeColor = System.Drawing.Color.Black;
            this.btn_cls.HoverState.Parent = this.btn_cls;
            this.btn_cls.Location = new System.Drawing.Point(799, 2);
            this.btn_cls.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.ShadowDecoration.Parent = this.btn_cls;
            this.btn_cls.Size = new System.Drawing.Size(61, 46);
            this.btn_cls.TabIndex = 26;
            this.btn_cls.Text = "X";
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(105, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 53);
            this.label4.TabIndex = 23;
            this.label4.Text = "Success IT Institute";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmExamDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 738);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExamDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamDetails";
            this.Load += new System.EventHandler(this.frmExamDetails_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.AddExam.ResumeLayout(false);
            this.AddExam.PerformLayout();
            this.UpdateExam.ResumeLayout(false);
            this.UpdateExam.PerformLayout();
            this.DeleteExam.ResumeLayout(false);
            this.DeleteExam.PerformLayout();
            this.ViewExam.ResumeLayout(false);
            this.ViewExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage AddExam;
        private MetroFramework.Controls.MetroTabPage UpdateExam;
        private MetroFramework.Controls.MetroTabPage DeleteExam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txt_ExName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txt_ExId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_ExName_Up;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_ExId_Up;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Ex_Delete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnExClear;
        private Guna.UI2.WinForms.Guna2Button btnExCancel;
        private Guna.UI2.WinForms.Guna2Button btnExAdd;
        private Guna.UI2.WinForms.Guna2Button btnExUpClear;
        private Guna.UI2.WinForms.Guna2Button btnExUpCancel;
        private Guna.UI2.WinForms.Guna2Button btnExUpdate;
        private Guna.UI2.WinForms.Guna2Button btnExDelClear;
        private Guna.UI2.WinForms.Guna2Button btnExDelCancel;
        private Guna.UI2.WinForms.Guna2Button btnExDelete;
        private MetroFramework.Controls.MetroTabPage ViewExam;
        private Guna.UI2.WinForms.Guna2Button btnExView;
        private Guna.UI2.WinForms.Guna2TextBox txt_Ex_View;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2RadioButton rbt_ExName;
        private Guna.UI2.WinForms.Guna2RadioButton rbt_ExId;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_mini;
        private Guna.UI2.WinForms.Guna2Button btn_maxi;
        private Guna.UI2.WinForms.Guna2Button btn_cls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error_msgEX;
        private System.Windows.Forms.Label error_msgEX_Up;
        private System.Windows.Forms.Label error_msgEX_Del;
        private Guna.UI2.WinForms.Guna2Button btnExView_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobPicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobPicker2;
    }
}