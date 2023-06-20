namespace project
{
    partial class frm_RP_Att
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RP_Att));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Att = new project.DataSet_Att();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mini = new Guna.UI2.WinForms.Guna2Button();
            this.btn_maxi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cls = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_StId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CoId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.DataTable1TableAdapter = new project.DataSet_AttTableAdapters.DataTable1TableAdapter();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Att)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet_Att;
            // 
            // DataSet_Att
            // 
            this.DataSet_Att.DataSetName = "DataSet_Att";
            this.DataSet_Att.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.guna2GradientPanel1.Location = new System.Drawing.Point(2, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(867, 86);
            this.guna2GradientPanel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 2);
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
            this.btn_mini.Location = new System.Drawing.Point(663, 2);
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
            this.btn_maxi.Location = new System.Drawing.Point(732, 2);
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
            this.btn_cls.Location = new System.Drawing.Point(802, 2);
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
            this.label4.Location = new System.Drawing.Point(106, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 53);
            this.label4.TabIndex = 23;
            this.label4.Text = "Success IT Institute";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer3.BackColor = System.Drawing.Color.LightSkyBlue;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "project.Report_Att.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(2, 208);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(867, 617);
            this.reportViewer3.TabIndex = 33;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(27, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 25);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Student Id:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(27, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Course Id:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_StId
            // 
            this.txt_StId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_StId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StId.DefaultText = "";
            this.txt_StId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_StId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_StId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StId.DisabledState.Parent = this.txt_StId;
            this.txt_StId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StId.FocusedState.Parent = this.txt_StId;
            this.txt_StId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StId.ForeColor = System.Drawing.Color.Black;
            this.txt_StId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StId.HoverState.Parent = this.txt_StId;
            this.txt_StId.Location = new System.Drawing.Point(203, 107);
            this.txt_StId.Name = "txt_StId";
            this.txt_StId.PasswordChar = '\0';
            this.txt_StId.PlaceholderText = "";
            this.txt_StId.SelectedText = "";
            this.txt_StId.ShadowDecoration.Parent = this.txt_StId;
            this.txt_StId.Size = new System.Drawing.Size(213, 35);
            this.txt_StId.TabIndex = 36;
            // 
            // txt_CoId
            // 
            this.txt_CoId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CoId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CoId.DefaultText = "";
            this.txt_CoId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CoId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CoId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoId.DisabledState.Parent = this.txt_CoId;
            this.txt_CoId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoId.FocusedState.Parent = this.txt_CoId;
            this.txt_CoId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoId.ForeColor = System.Drawing.Color.Black;
            this.txt_CoId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoId.HoverState.Parent = this.txt_CoId;
            this.txt_CoId.Location = new System.Drawing.Point(203, 160);
            this.txt_CoId.Name = "txt_CoId";
            this.txt_CoId.PasswordChar = '\0';
            this.txt_CoId.PlaceholderText = "";
            this.txt_CoId.SelectedText = "";
            this.txt_CoId.ShadowDecoration.Parent = this.txt_CoId;
            this.txt_CoId.Size = new System.Drawing.Size(213, 35);
            this.txt_CoId.TabIndex = 37;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.CheckedState.Parent = this.btn_Search;
            this.btn_Search.CustomImages.Parent = this.btn_Search;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.DisabledState.Parent = this.btn_Search;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.HoverState.Parent = this.btn_Search;
            this.btn_Search.Location = new System.Drawing.Point(579, 98);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Parent = this.btn_Search;
            this.btn_Search.Size = new System.Drawing.Size(182, 44);
            this.btn_Search.TabIndex = 38;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.CheckedState.Parent = this.btn_Cancel;
            this.btn_Cancel.CustomImages.Parent = this.btn_Cancel;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.DisabledState.Parent = this.btn_Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.HoverState.Parent = this.btn_Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(579, 154);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(182, 44);
            this.btn_Cancel.TabIndex = 39;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_RP_Att
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 830);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_CoId);
            this.Controls.Add(this.txt_StId);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RP_Att";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP_Att";
            this.Load += new System.EventHandler(this.frm_RP_Att_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Att)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_mini;
        private Guna.UI2.WinForms.Guna2Button btn_maxi;
        private Guna.UI2.WinForms.Guna2Button btn_cls;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_StId;
        private Guna.UI2.WinForms.Guna2TextBox txt_CoId;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet_Att DataSet_Att;
        private DataSet_AttTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
    }
}