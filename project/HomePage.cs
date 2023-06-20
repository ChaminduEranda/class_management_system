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
    public partial class frm_HomePage : Form
    {
        
        public frm_HomePage()
        {
            InitializeComponent();
        }
       

        private void frm_HomePage_Load(object sender, EventArgs e)
        {
           
        }
        private void Tile_Student_Click(object sender, EventArgs e)
        {
           
            Hide();
            frmStudent obj = new frmStudent();
            obj.Show();
        }

        private void Tile_Teacher_Click(object sender, EventArgs e)
        {
            Hide();
            frmTeacher obj = new frmTeacher();
            obj.Show();
        }

        private void Tile_Instructor_Click(object sender, EventArgs e)
        {
            Hide();
            frmInstructor obj = new frmInstructor();
            obj.Show();
        }

        private void Tile_ExamDetails_Click(object sender, EventArgs e)
        {
            Hide();
            frmExamDetails obj = new frmExamDetails();
            obj.Show();
        }

        private void Tile_Courses_Click(object sender, EventArgs e)
        {
            Hide();
            frmCourse obj = new frmCourse();
            obj.Show();
        }

        private void Tile_ExamMarks_Click(object sender, EventArgs e)
        {
            Hide();
            frmExamMarks obj = new frmExamMarks();
            obj.Show();
        }

        private void Tile_Attendance_Click(object sender, EventArgs e)
        {

            Hide();
            frm_Attendance obj = new frm_Attendance(label2.Text);
            obj.Show();
        }
        private void Tile_Reports_Click(object sender, EventArgs e)
        {
            Hide();
            frm_ReportsWindow obj = new frm_ReportsWindow();
            obj.Show();
        }
        private void Tile_Registrations_Click(object sender, EventArgs e)
        {
            Hide();
            frm_C_S_T obj = new frm_C_S_T();
            obj.Show();
        }
        private void linkLabel_UR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            UserRegistration obj = new UserRegistration();
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

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
