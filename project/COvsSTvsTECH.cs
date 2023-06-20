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
    public partial class frm_C_S_T : Form
    {
        public frm_C_S_T()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        //Student in Course
        private void frm_C_S_T_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
            dobPicker1.Value = DateTime.Today;
            
        }

        private void btn_Save_S_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_studentId.Text))
            {
                error_msg1.Text = "Please Enter Student Id!";
                txt_studentId.Focus();
            }
            else if (txt_studentId.Text.Any(char.IsLetter))
            {
                error_msg1.Text = "Student Id Can not Have Characters!";
                txt_studentId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CId_CS.Text))
            {
                error_msg1.Text = "Please Select a Course Id!";
                txt_CId_CS.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Batch_CS.Text))
            {
                error_msg1.Text = "Please Enter Course Batch!";
                txt_Batch_CS.Focus();
            }
            else if (dobPicker1.Value >= DateTime.Now)
            {
                error_msg1.Text = "Please Enter Register Date Correctly!";
                dobPicker1.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into student_course values ('" +txt_studentId.Text + "', '" + txt_CId_CS.Text + "','" + txt_Batch_CS.Text + "', '" + dobPicker1.Value + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txt_studentId.Clear();
                txt_CId_CS.Clear();
                error_msg1.ResetText();
                dobPicker1.ResetText();
            }
        }

        private void btn_Update_S_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_studentId.Text))
            {
                error_msg1.Text = "Please Enter Student Id!";
                txt_studentId.Focus();
            }
            else if (txt_studentId.Text.Any(char.IsLetter))
            {
                error_msg1.Text = "Student Id Can not Have Characters!";
                txt_studentId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CId_CS.Text))
            {
                error_msg1.Text = "Please Select a Course Id!";
                txt_CId_CS.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Batch_CS.Text))
            {
                error_msg1.Text = "Please Enter Course Batch!";
                txt_Batch_CS.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update student_course set  register_date= '" + dobPicker1.Value + "' where student_id = '" + txt_studentId.Text + "' AND course_id = '" + txt_CId_CS.Text + "' AND batch= '"+txt_Batch_CS.Text+"' ", con);
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
                txt_studentId.Clear();
                txt_CId_CS.Clear();
                error_msg1.ResetText();
            }
        }

        private void btn_Delete_S_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_studentId.Text))
            {
                error_msg1.Text = "Please Enter Student Id!";
                txt_studentId.Focus();
            }
            else if (txt_studentId.Text.Any(char.IsLetter))
            {
                error_msg1.Text = "Student Id Can not Have Characters!";
                txt_studentId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CId_CS.Text))
            {
                error_msg1.Text = "Please Select a Course Id!";
                txt_CId_CS.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Batch_CS.Text))
            {
                error_msg1.Text = "Please Enter Course Batch!";
                txt_Batch_CS.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from student_course where student_id= '" + txt_studentId.Text + "' AND course_id = '" + txt_CId_CS.Text + "' AND batch='"+txt_Batch_CS.Text+"' ", con);
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
                txt_studentId.Clear();
                txt_CId_CS.Clear();
                txt_Batch_CS.Clear();
                error_msg1.ResetText();
            }
        }

        private void btn_Clear_S_Click(object sender, EventArgs e)
        {
            txt_studentId.Clear();
            txt_CId_CS.Clear();
            txt_Batch_CS.Clear();
            error_msg1.ResetText();
        }

        private void btn_Cancel_S_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }



                                  //Teachers in Courses

        private void btn_Save_T_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TeacherId.Text))
            {
                error_msg2.Text = "Please Enter Teacher Id!";
                txt_studentId.Focus();
            }
            else if (txt_TeacherId.Text.Any(char.IsLetter))
            {
                error_msg2.Text = "Teacher Id Can not Have Characters!";
                txt_TeacherId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CId_CT.Text))
            {
                error_msg2.Text = "Please Select a Course Id!";
                txt_CId_CS.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Batch_CT.Text))
            {
                error_msg2.Text = "Please Select a Course Batch!";
                txt_Batch_CT.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into teacher_course values ( '" + txt_TeacherId.Text + "','" + txt_CId_CT.Text + "','" + txt_Batch_CT.Text+ "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txt_TeacherId.Clear();
                txt_CId_CT.Clear();
                txt_Batch_CT.Clear();
                error_msg2.ResetText();
            }
        }

       
        private void btn_Clear_T_Click(object sender, EventArgs e)
        {
            txt_TeacherId.Clear();
            txt_CId_CT.Clear();
            txt_Batch_CT.Clear();
            error_msg2.ResetText();
        }

        private void btn_Cancel_T_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //Exam vs Course
        private void btnSave_E_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EId_EC.Text))
            {
                error_msg3.Text = "Please Enter Exam Id!";
                txt_EId_EC.Focus();
            }
            else if (txt_EId_EC.Text.Any(char.IsLetter))
            {
                error_msg3.Text = "Exam Id Can not Have Characters!";
                txt_EId_EC.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CId_EC.Text))
            {
                error_msg3.Text = "Please Select a Course Id!";
                txt_CId_EC.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Batch_EC.Text))
            {
                error_msg3.Text = "Please Select a Course Batch!";
                txt_Batch_EC.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into course_exam values ('" + txt_CId_EC.Text + "','" + txt_Batch_EC.Text + "','" + txt_EId_EC.Text + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txt_EId_EC.Clear();
                txt_CId_EC.Clear();
                txt_Batch_EC.Clear();
                error_msg3.ResetText();

            }
        }

        private void btnClear_E_Click(object sender, EventArgs e)
        {
            txt_EId_EC.Clear();
            txt_CId_EC.Clear();
            txt_Batch_EC.Clear();
            error_msg3.ResetText();
        }

        private void btnCancel_E_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

      

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        //VIEW for ALL
        private void btnView_S_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_St.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from student_course where student_id = '" + txt_C_View.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                if (rbt_Tech.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from teacher_course where teacher_id = '" + txt_C_View.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                if (rbt_Tech.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from course_exam where exam_id = '" + txt_C_View.Text + "'", con);
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
