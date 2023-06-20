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
    public partial class HomePage_INS : Form
    {
        public HomePage_INS()
        {
            InitializeComponent();
        }


        private void HomePage_INS_Load(object sender, EventArgs e)
        {

        }
        
        private void Tile_Student_Click(object sender, EventArgs e)
        {
            Hide();
            frmStudent obj = new frmStudent(label1.Text);
            obj.Show();
        }

        private void Tile_Instructor_Click(object sender, EventArgs e)
        {
            Hide();
            frmInstructor obj = new frmInstructor(label1.Text);
            obj.Show();
        }

        private void Tile_ExamMarks_Click(object sender, EventArgs e)
        {
            Hide();
            frmExamMarks obj = new frmExamMarks(label1.Text);
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

        private void linkLabel_UL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            frmLogin obj = new frmLogin();
            obj.Show();
        }
    }
}
