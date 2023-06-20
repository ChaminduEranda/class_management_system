using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace project
{
    public partial class frmInstructor : Form
    {
        public frmInstructor()
        {
            InitializeComponent();
        }
        String Role;
        public frmInstructor(string r)
        {
            InitializeComponent();
            Role = r;
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;


        private void frmInstructor_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
            dobPicker1.Value = DateTime.Today;
            dobPicker2.Value = DateTime.Today;
            SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(i_id as int)),0)+1 FROM instructor ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txt_InsId.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_InsName;

            if(Role=="INS")
            {
                btnInCancel.Hide();
                btnInsDelCancel.Hide();
                btnInsUpCancel.Hide();
                btnInsView_Cancel.Hide();
            }
            else
            {
                lbl_Back.Hide();
            }
        }
        private void btnInsSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_InsId.Text))
            {
                error_msgINS.Text = "Please Enter Instructor Id!";
                txt_InsId.Focus();
            }
            else if (txt_InsId.Text.Any(char.IsLetter))
            {
                error_msgINS.Text = "Instructor Id can not Have Characters!";
                txt_InsId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsName.Text))
            {
                error_msgINS.Text = "Please Enter First Name!";
                txt_InsName.Focus();
            }
            else if (txt_InsName.Text.Any(char.IsDigit))
            {
                error_msgINS.Text = "First Name cannot have Numbers!";
                txt_InsName.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsName2.Text))
            {
                error_msgINS.Text = "Please Enter Last Name!";
                txt_InsName2.Focus();
            }
            else if (txt_InsName2.Text.Any(char.IsDigit))
            {
                error_msgINS.Text = "Last Name cannot have Numbers!";
                txt_InsName2.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsAddress.Text))
            {
                error_msgINS.Text = "Please Enter Instructor Address!";
                txt_InsAddress.Focus();
            }
            else if (DateTime.Today <= dobPicker1.Value)
            {
                error_msgINS.Text = "Please Select Instructor Birthday Correctly!";
                dobPicker1.Focus();
            }
            else if (txt_InsEmail.Text.Length == 0)
            {
                error_msgINS.Text = "Please Enter Instructor Email Address!";
                txt_InsEmail.Focus();
            }
            else if (!Regex.IsMatch(txt_InsEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msgINS.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_InsEmail.Focus();
            }
            else if (txt_InsPhone.Text.Length == 0)
            {
                error_msgINS.Text = "Please Enter Instructor Phone No!";
                txt_InsPhone.Focus();
            }
            else if (!Regex.IsMatch(txt_InsPhone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msgINS.Text = "Telephone No is not Valid!";
                txt_InsPhone.Focus();
            }
            else if (txt_InsNIC.Text.Length == 0)
            {
                error_msgINS.Text = "Please Enter Instructor NIC!";
                txt_InsNIC.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into instructor values ('" + txt_InsId.Text + "', '" + txt_InsName.Text + "','" + txt_InsName2.Text + "', '" + txt_InsAddress.Text + "',  '" + dobPicker1.Value + "', '" + txt_InsEmail.Text + "', '" + txt_InsPhone.Text + "', '" + txt_InsNIC.Text + "', '" + txt_Ins_TId.Text + "') ", con);
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
                //txt_InsId.Clear();
                txt_InsName.Clear();
                txt_InsName2.Clear();
                txt_InsAddress.Clear();
                dobPicker1.ResetText();
                txt_InsEmail.Clear();
                txt_InsPhone.Clear();
                txt_InsNIC.Clear();
                txt_Ins_TId.Clear();
                error_msgINS.ResetText();

                SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(i_id as int)),0)+1 FROM instructor ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_InsId.Text = dt.Rows[0][0].ToString();
                this.ActiveControl = txt_InsName;
            }
        }
        private void btnInsClear_Click(object sender, EventArgs e)
        {
            //txt_InsId.Clear();
            txt_InsName.Clear();
            txt_InsName2.Clear();
            txt_InsAddress.Clear();
            dobPicker1.ResetText();
            txt_InsEmail.Clear();
            txt_InsPhone.Clear();
            txt_InsNIC.Clear();
            txt_Ins_TId.Clear();
            error_msgINS.ResetText();
        }

        private void btnInCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //UPDATE
        private void btnInsUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_InsId_Up.Text))
            {
                error_msgINS_Up.Text = "Please Enter Instructor Id!";
                txt_InsId_Up.Focus();
            }
            else if (txt_InsId_Up.Text.Any(char.IsLetter))
            {
                error_msgINS_Up.Text = "Instructor Id can not Have Characters!";
                txt_InsId_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsName_Up.Text))
            {
                error_msgINS_Up.Text = "Please Enter First Name!";
                txt_InsName_Up.Focus();
            }
            else if (txt_InsName_Up.Text.Any(char.IsDigit))
            {
                error_msgINS_Up.Text = "First Name cannot have Numbers!";
                txt_InsName_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsName_Up2.Text))
            {
                error_msgINS_Up.Text = "Please Enter Last Name!";
                txt_InsName_Up2.Focus();
            }
            else if (txt_InsName_Up2.Text.Any(char.IsDigit))
            {
                error_msgINS_Up.Text = "Last Name cannot have Numbers!";
                txt_InsName_Up2.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsAddress_Up.Text))
            {
                error_msgINS_Up.Text = "Please Enter Instructor Address!";
                txt_InsAddress_Up.Focus();
            }
            else if (DateTime.Today <= dobPicker2.Value)
            {
                error_msgINS_Up.Text = "Please Select Instructor Birthday Correctly!";
                dobPicker2.Focus();
            }
            else if (txt_InsEmail_Up.Text.Length == 0)
            {
                error_msgINS_Up.Text = "Please Enter Instructor Email Address!";
                txt_InsEmail_Up.Focus();
            }
            else if (!Regex.IsMatch(txt_InsEmail_Up.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msgINS_Up.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_InsEmail_Up.Focus();
            }
            else if (txt_InsPhone_Up.Text.Length == 0)
            {
                error_msgINS_Up.Text = "Please Enter Instructor Phone No!";
                txt_InsPhone_Up.Focus();
            }
            else if (!Regex.IsMatch(txt_InsPhone_Up.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msgINS_Up.Text = "Telephone No is not Valid";
                txt_InsPhone_Up.Focus();
            }
            else if (txt_InsNIC_Up.Text.Length == 0)
            {
                error_msgINS_Up.Text = "Please Enter Instructor NIC!";
                txt_InsNIC_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_InsTId_Up.Text))
            {
                error_msgINS_Up.Text = "Please Enter Instructor Id!";
                txt_InsTId_Up.Focus();
            }
            else if (txt_InsTId_Up.Text.Any(char.IsLetter))
            {
                error_msgINS_Up.Text = "Instructor Id can not Have Characters!";
                txt_InsTId_Up.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update instructor set  i_name= '" + txt_InsName_Up.Text + "', i_address= '" + txt_InsAddress_Up.Text + "', dob=  '" + dobPicker2.Value + "', i_email= '" + txt_InsEmail_Up.Text + "', mobile= '" + txt_InsPhone_Up.Text + "', nic= '" + txt_InsNIC_Up.Text + "', teacher_id= '" + txt_InsTId_Up.Text + "'  where i_id= '" + txt_InsId_Up.Text + "'", con);
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
                txt_InsId_Up.Clear();
                txt_InsName_Up.Clear();
                txt_InsName_Up2.Clear();
                txt_InsAddress_Up.Clear();
                dobPicker2.ResetText();
                txt_InsEmail_Up.Clear();
                txt_InsPhone_Up.Clear();
                txt_InsNIC_Up.Clear();
                txt_InsTId_Up.Clear();
                error_msgINS_Up.ResetText();
            }
        }
        private void btnInsUpClear_Click(object sender, EventArgs e)
        {
            txt_InsId_Up.Clear();
            txt_InsName_Up.Clear();
            txt_InsName_Up2.Clear();
            txt_InsAddress_Up.Clear();
            dobPicker2.ResetText();
            txt_InsEmail_Up.Clear();
            txt_InsPhone_Up.Clear();
            txt_InsNIC_Up.Clear();
            txt_InsTId_Up.Clear();
            error_msgINS_Up.ResetText();
        }

        private void btnInsUpCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //DELETE
        private void btnInsDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_InsId_Del.Text))
            {
                error_msgINS_Del.Text = "Please Enter Instructor Id!";
                txt_InsId_Del.Focus();
            }
            else if (txt_InsId_Del.Text.Any(char.IsLetter))
            {
                error_msgINS_Del.Text = "Instructor Id Can not Have Characters!";
                txt_InsId_Del.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from instructor where i_id = '" + txt_InsId_Del.Text + "'", con);
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
                txt_InsId_Del.Clear();
                error_msgINS_Del.ResetText();
            }
        }

        private void btnInsDelClear_Click(object sender, EventArgs e)
        {
            txt_InsId_Del.Clear();
        }

        private void btnInsDelCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //VIEW
        private void btnInsView_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Insid.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from instructor where i_id = '" + txt_Ins_View.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (rbt_InsNIC.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from instructor where nic LIKE '" + txt_Ins_View.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                if (txt_Ins_View.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from instructor", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                txt_Ins_View.Clear();
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_Ins_View.Clear();
            
        }

        private void btnInsView_Cancel_Click(object sender, EventArgs e)
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

        private void lbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            HomePage_INS obj = new HomePage_INS();
            obj.Show();
        }
    }
}
