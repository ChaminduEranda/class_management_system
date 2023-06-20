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
    public partial class frm_ReportsWindow : Form
    {
        public frm_ReportsWindow()
        {
            InitializeComponent();
        }

        private void Tile_St_Marks_Click(object sender, EventArgs e)
        {
            Hide();
            frm_RP_STM obj = new frm_RP_STM();
            obj.Show();
        }

        private void Tile_RegSt_Click(object sender, EventArgs e)
        {
            Hide();
            frm_RP_T_CO obj = new frm_RP_T_CO();
            obj.Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Hide();
            frm_RP_Att obj = new frm_RP_Att();
            obj.Show();
        }



        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
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
