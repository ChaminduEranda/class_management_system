using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frm_RP_T_CO : Form
    {
        public frm_RP_T_CO()
        {
            InitializeComponent();
        }

        private void frm_RP_T_CO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_T_CO.teacher_course' table. You can move, or remove it, as needed.
            this.teacher_courseTableAdapter.Fill(this.DataSet_T_CO.teacher_course);

            this.reportViewer2.RefreshReport();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_ReportsWindow obj = new frm_ReportsWindow();
            obj.Show();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
