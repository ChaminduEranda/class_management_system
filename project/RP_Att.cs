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
    public partial class frm_RP_Att : Form
    {
        public frm_RP_Att()
        {
            InitializeComponent();
        }

        private void frm_RP_Att_Load(object sender, EventArgs e)
        {
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSet_Att.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet_Att.DataTable1, Convert.ToInt32(txt_StId.Text),txt_CoId.Text);

            this.reportViewer3.RefreshReport();
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
