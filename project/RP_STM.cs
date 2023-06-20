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
    public partial class frm_RP_STM : Form
    {
        public frm_RP_STM()
        {
            InitializeComponent();
        }

        private void RP_STM_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           
                // TODO: This line of code loads data into the 'DataSet_STM.student_exam' table. You can move, or remove it, as needed.
                this.student_examTableAdapter.Fill(this.DataSet_STM.student_exam, Convert.ToInt32(txt_EId.Text), Convert.ToInt32(txt_ML.Text));

                this.reportViewer1.RefreshReport();
            
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
