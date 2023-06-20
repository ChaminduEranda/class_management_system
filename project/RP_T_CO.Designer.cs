namespace project
{
    partial class frm_RP_T_CO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RP_T_CO));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.teacher_courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_T_CO = new project.DataSet_T_CO();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mini = new Guna.UI2.WinForms.Guna2Button();
            this.btn_maxi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cls = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.teacher_courseTableAdapter = new project.DataSet_T_COTableAdapters.teacher_courseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_T_CO)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_courseBindingSource
            // 
            this.teacher_courseBindingSource.DataMember = "teacher_course";
            this.teacher_courseBindingSource.DataSource = this.DataSet_T_CO;
            // 
            // DataSet_T_CO
            // 
            this.DataSet_T_CO.DataSetName = "DataSet_T_CO";
            this.DataSet_T_CO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.guna2GradientPanel1.Controls.Add(this.btn_Cancel);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btn_mini);
            this.guna2GradientPanel1.Controls.Add(this.btn_maxi);
            this.guna2GradientPanel1.Controls.Add(this.btn_cls);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(2, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(867, 113);
            this.guna2GradientPanel1.TabIndex = 31;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Cancel.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel.BorderThickness = 1;
            this.btn_Cancel.CheckedState.Parent = this.btn_Cancel;
            this.btn_Cancel.CustomImages.Parent = this.btn_Cancel;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.DisabledState.Parent = this.btn_Cancel;
            this.btn_Cancel.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.HoverState.Parent = this.btn_Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(690, 63);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(157, 44);
            this.btn_Cancel.TabIndex = 43;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
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
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.BackColor = System.Drawing.Color.LightSkyBlue;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.teacher_courseBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "project.Report_T_CO.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(2, 113);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(867, 705);
            this.reportViewer2.TabIndex = 32;
            // 
            // teacher_courseTableAdapter
            // 
            this.teacher_courseTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RP_T_CO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 830);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RP_T_CO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP_T_CO";
            this.Load += new System.EventHandler(this.frm_RP_T_CO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_T_CO)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_mini;
        private Guna.UI2.WinForms.Guna2Button btn_maxi;
        private Guna.UI2.WinForms.Guna2Button btn_cls;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource teacher_courseBindingSource;
        private DataSet_T_CO DataSet_T_CO;
        private DataSet_T_COTableAdapters.teacher_courseTableAdapter teacher_courseTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
    }
}