using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class frmExamMarks : Form
    {
        public frmExamMarks()
        {
            InitializeComponent();
        }

        String Role;
        public frmExamMarks(string r)
        {
            InitializeComponent();
            Role = r;
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmExamMarks_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");

            if(Role=="INS")
            {
                btnEmCancel.Hide();
                btnEmDelCancel.Hide();
                btnEmUpCancel.Hide();
                btnEmView_Cancel.Hide();
            }
            else
            {
                lbl_Back.Hide();
            }
        }
        private void btnEmAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EmStId.Text))
            {
                error_msgEM.Text = "Please Enter Student Id!";
                txt_EmStId.Focus();
            }
            else if (txt_EmStId.Text.Any(char.IsLetter))
            {
                error_msgEM.Text = "Student Id Can not Have Characters!";
                txt_EmStId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_EmExId.Text))
            {
                error_msgEM.Text = "Please Enter Exam Id!";
                txt_EmExId.Focus();
            }
            else if (!(txt_EmExId.Text.Any(char.IsDigit)))
            {
                error_msgEM.Text = "Exam Id Can not Have Characters!";
                txt_EmExId.Focus();
            }
           
            else if (string.IsNullOrEmpty(txt_EmMarks.Text))
            {
                error_msgEM.Text = "Please Enter Exam Marks!";
                txt_EmMarks.Focus();
            }
            else if (!(txt_EmMarks.Text.Any(char.IsDigit)))
            {
                error_msgEM.Text = "Exam Marks cannot have Characters";
                txt_EmMarks.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into student_exam values ('" + txt_EmStId.Text + "', '" + txt_EmExId.Text + "','" + txt_EmMarks.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_EmStId.Clear();               
                txt_EmExId.Clear();
                txt_EmMarks.Clear();
                error_msgEM.ResetText();
            }
        }
        private void btnEmClear_Click(object sender, EventArgs e)
        {
            txt_EmStId.Clear();
            txt_EmExId.Clear();
            txt_EmMarks.Clear();
            error_msgEM.ResetText();
        }

        private void btnEmCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //UPDATE
        private void btnEmUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EmStId_Up.Text))
            {
                error_msgEM_Up.Text = "Please Enter Student Id!";
                txt_EmStId_Up.Focus();
            }
            else if (txt_EmStId_Up.Text.Any(char.IsLetter))
            {
                error_msgEM.Text = "Student Id Can not Have Characters!";
                txt_EmStId_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_EmExId_Up.Text))
            {
                error_msgEM_Up.Text = "Please Enter Exam Id!";
                txt_EmExId_Up.Focus();
            }
            else if (!(txt_EmExId_Up.Text.Any(char.IsDigit)))
            {
                error_msgEM.Text = "Exam Id Can not Have Characters!";
                txt_EmExId_Up.Focus();
            }
          
            else if (string.IsNullOrEmpty(txt_EmMarks_Up.Text))
            {
                error_msgEM_Up.Text = "Please Enter Exam Marks!";
                txt_EmMarks_Up.Focus();
            }
            else if (!(txt_EmMarks_Up.Text.Any(char.IsDigit)))
            {
                error_msgEM_Up.Text = "Exam Marks cannot have Characters";
                txt_EmMarks_Up.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update student_exam set  exam_marks= '" + txt_EmMarks_Up.Text + "' where student_id= '" + txt_EmStId_Up.Text + "' AND exam_id = '" + txt_EmExId_Up.Text + "' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
                catch (SqlException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_EmStId_Up.Clear();               
                txt_EmExId_Up.Clear();
                txt_EmMarks_Up.Clear();
                error_msgEM_Up.ResetText();
            }
        }
        private void btnEmUpClear_Click(object sender, EventArgs e)
        {
            txt_EmStId_Up.Clear();
            txt_EmExId_Up.Clear();
            txt_EmMarks_Up.Clear();
            error_msgEM_Up.ResetText();
        }

        private void btnEmUpCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //DELETE
        private void btnEmDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EmStId_Del.Text))
            {
                error_msgEM_Del.Text = "Please Enter Student Id!";
                txt_EmStId_Del.Focus();
            }
            else if (txt_EmStId_Del.Text.Any(char.IsLetter))
            {
                error_msgEM_Del.Text = "Student Id Can not Have Characters!";
                txt_EmStId_Del.Focus();
            }
            else if (string.IsNullOrEmpty(txt_EmExId_Del.Text))
            {
                error_msgEM_Del.Text = "Please Enter Exam Id!";
               txt_EmExId_Del.Focus();
            }
            else if (!(txt_EmExId_Del.Text.Any(char.IsDigit)))
            {
                error_msgEM_Del.Text = "Exam Id Can not Have Characters!";
                txt_EmExId_Del.Focus();
            }
           
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from student_exam where student_id= '" + txt_EmStId_Del.Text + "' AND exam_id = '" + txt_EmExId_Del.Text + "' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    cmd.Dispose();
                }
                catch (SqlException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_EmStId_Del.Clear();
                txt_EmExId_Del.Clear();
                error_msgEM_Del.ResetText();
            }
        }

        private void btnEmDelClear_Click(object sender, EventArgs e)
        {
            txt_EmStId_Del.Clear();
            txt_EmExId_Del.Clear();         
            error_msgEM_Del.ResetText();
        }

        private void btnEmDelCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //VIEW
        private void btnEmView_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_EmStId.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from student_exam where student_id= '" + txt_EmView.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (rbt_EmExId.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from student_exam where exam_id='" + txt_EmView.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
               
                if (txt_EmView.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from student_exam", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_EmView.Clear();
           
        }

        private void btnEmView_Cancel_Click(object sender, EventArgs e)
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

        private void AddExamMarks_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            HomePage_INS obj = new HomePage_INS();
            obj.Show();
        }
    }
}
