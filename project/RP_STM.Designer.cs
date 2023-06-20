namespace project
{
    partial class frm_RP_STM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RP_STM));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.student_examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_STM = new project.DataSet_STM();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mini = new Guna.UI2.WinForms.Guna2Button();
            this.btn_maxi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cls = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_EId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ML = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.student_examTableAdapter = new project.DataSet_STMTableAdapters.student_examTableAdapter();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.student_examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_STM)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_examBindingSource
            // 
            this.student_examBindingSource.DataMember = "student_exam";
            this.student_examBindingSource.DataSource = this.DataSet_STM;
            // 
            // DataSet_STM
            // 
            this.DataSet_STM.DataSetName = "DataSet_STM";
            this.DataSet_STM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.guna2GradientPanel1.TabIndex = 30;
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
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.LightSkyBlue;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.student_examBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project.Report_STM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 216);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(867, 619);
            this.reportViewer1.TabIndex = 31;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(101, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Exam Id:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(101, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 20);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Marks Limit:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_EId
            // 
            this.txt_EId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EId.DefaultText = "";
            this.txt_EId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EId.DisabledState.Parent = this.txt_EId;
            this.txt_EId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EId.FocusedState.Parent = this.txt_EId;
            this.txt_EId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EId.ForeColor = System.Drawing.Color.Black;
            this.txt_EId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EId.HoverState.Parent = this.txt_EId;
            this.txt_EId.Location = new System.Drawing.Point(241, 100);
            this.txt_EId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_EId.Name = "txt_EId";
            this.txt_EId.PasswordChar = '\0';
            this.txt_EId.PlaceholderText = "";
            this.txt_EId.SelectedText = "";
            this.txt_EId.ShadowDecoration.Parent = this.txt_EId;
            this.txt_EId.Size = new System.Drawing.Size(245, 37);
            this.txt_EId.TabIndex = 34;
            // 
            // txt_ML
            // 
            this.txt_ML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ML.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ML.DefaultText = "";
            this.txt_ML.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ML.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ML.DisabledState.Parent = this.txt_ML;
            this.txt_ML.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ML.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ML.FocusedState.Parent = this.txt_ML;
            this.txt_ML.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ML.ForeColor = System.Drawing.Color.Black;
            this.txt_ML.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ML.HoverState.Parent = this.txt_ML;
            this.txt_ML.Location = new System.Drawing.Point(241, 157);
            this.txt_ML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ML.Name = "txt_ML";
            this.txt_ML.PasswordChar = '\0';
            this.txt_ML.PlaceholderText = "";
            this.txt_ML.SelectedText = "";
            this.txt_ML.ShadowDecoration.Parent = this.txt_ML;
            this.txt_ML.Size = new System.Drawing.Size(245, 37);
            this.txt_ML.TabIndex = 35;
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
            this.btn_Search.Location = new System.Drawing.Point(679, 95);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Parent = this.btn_Search;
            this.btn_Search.Size = new System.Drawing.Size(157, 44);
            this.btn_Search.TabIndex = 36;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // student_examTableAdapter
            // 
            this.student_examTableAdapter.ClearBeforeFill = true;
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
            this.btn_Cancel.Location = new System.Drawing.Point(679, 166);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(157, 44);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_RP_STM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 830);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_ML);
            this.Controls.Add(this.txt_EId);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RP_STM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP_STM";
            this.Load += new System.EventHandler(this.RP_STM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_STM)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_EId;
        private Guna.UI2.WinForms.Guna2TextBox txt_ML;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private System.Windows.Forms.BindingSource student_examBindingSource;
        private DataSet_STM DataSet_STM;
        private DataSet_STMTableAdapters.student_examTableAdapter student_examTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
    }
}