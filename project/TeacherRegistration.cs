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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
            dobPicker1.Value = DateTime.Today;
            dobPicker2.Value = DateTime.Today;
            SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(t_id as int)),0)+1 FROM teacher ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txt_TechId.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_TechName;
        }
        private void btnTechSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TechId.Text))
            {
                error_msgTech.Text = "Please Enter Teacher Id!";
                txt_TechId.Focus();
            }
            else if (txt_TechId.Text.Any(char.IsLetter))
            {
                error_msgTech.Text = "Teacher Id Can not Have Characters!";
                txt_TechId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_TechName.Text))
            {
                error_msgTech.Text = "Please Enter First Name!";
                txt_TechName.Focus();
            }
            else if (txt_TechName.Text.Any(char.IsDigit))
            {
                error_msgTech.Text = "First Name cannot have Numbers!";
                txt_TechName.Focus();
            }
            else if (string.IsNullOrEmpty(txt_TechName2.Text))
            {
                error_msgTech.Text = "Please Enter Last Name!";
                txt_TechName2.Focus();
            }
            else if (txt_TechName2.Text.Any(char.IsDigit))
            {
                error_msgTech.Text = "Last Name cannot have Numbers!";
                txt_TechName2.Focus();
            }
            else if (string.IsNullOrEmpty(txt_TechAddress.Text))
            {
                error_msgTech.Text = "Please Enter Teacher Address!";
                txt_TechAddress.Focus();
            }
            else if (DateTime.Today <= dobPicker1.Value)
            {
                error_msgTech.Text = "Please Select Teacher Birthday Correctly!";
                dobPicker1.Focus();
            }
            else if (txt_TechEmail.Text.Length == 0)
            {
                error_msgTech.Text = "Please Enter Teacher Email Address!";
                txt_TechEmail.Focus();
            }
            else if (!Regex.IsMatch(txt_TechEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msgTech.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_TechEmail.Focus();
            }
            else if (txt_TechPhone.Text.Length == 0)
            {
                error_msgTech.Text = "Please Enter Teacher Phone No!";
                txt_TechPhone.Focus();
            }
            else if (!Regex.IsMatch(txt_TechPhone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msgTech.Text = "Telephone No is not Valid";
                txt_TechPhone.Focus();
            }
            else if (txt_TechNIC.Text.Length == 0)
            {
                error_msgTech.Text = "Please Enter Teacher NIC!";
                txt_TechNIC.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into teacher values ('" + txt_TechId.Text + "', '" + txt_TechName.Text + "','"+txt_TechName2.Text+"', '" + txt_TechAddress.Text + "',  '" + dobPicker1.Value + "', '" + txt_TechEmail.Text + "', '" + txt_TechPhone.Text + "', '" + txt_TechNIC.Text + "') ", con);
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
                //txt_TechId.Clear();
                txt_TechName.Clear();
                txt_TechName2.Clear();
                txt_TechAddress.Clear();
                dobPicker1.ResetText();
                txt_TechEmail.Clear();
                txt_TechPhone.Clear();
                txt_TechNIC.Clear();
                error_msgTech.ResetText();

                SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(t_id as int)),0)+1 FROM teacher ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_TechId.Text = dt.Rows[0][0].ToString();
                this.ActiveControl = txt_TechName;
            }
        }
        private void btnTechClear_Click(object sender, EventArgs e)
        {
            //txt_TechId.Clear();
            txt_TechName.Clear();
            txt_TechName2.Clear();
            txt_TechAddress.Clear();
            dobPicker1.ResetText();
            txt_TechEmail.Clear();
            txt_TechPhone.Clear();
            txt_TechNIC.Clear();
            error_msgTech.ResetText();
        }

        private void btnTechCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //UPDATE
        private void btnTechUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TechId_Up.Text))
            {
                error_msgTech_Up.Text = "Please Enter Teacher Id!";
                txt_TechId_Up.Focus();
            }
            else if (txt_TechId_Up.Text.Any(char.IsLetter))
            {
                error_msgTech_Up.Text = "Teacher Id Can not Have Characters!";
                txt_TechId_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_TechName_Up.Text))
            {
                error_msgTech_Up.Text = "Please First Teacher Name!";
                txt_TechName_Up.Focus();
            }
            else if (txt_TechName_Up.Text.Any(char.IsDigit))
            {
                error_msgTech_Up.Text = "First Name cannot have Numbers!";
                txt_TechName_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_TechName_Up2.Text))
            {
                error_msgTech_Up.Text = "Please Enter Last Name!";
                txt_TechName_Up2.Focus();
            }
            else if (txt_TechName_Up2.Text.Any(char.IsDigit))
            {
                error_msgTech_Up.Text = "Last Name cannot have Numbers!";
                txt_TechName_Up2.Focus();
            }
            else if (string.IsNullOrEmpty(txt_TechAddress_Up.Text))
            {
                error_msgTech_Up.Text = "Please Enter Teacher Address!";
                txt_TechAddress_Up.Focus();
            }
            else if (DateTime.Today <= dobPicker2.Value)
            {
                error_msgTech_Up.Text = "Please Select Teacher Birthday Correctly!";
                dobPicker2.Focus();
            }
            else if (txt_TechEmail_Up.Text.Length == 0)
            {
                error_msgTech_Up.Text = "Please Enter Teacher Email Address!";
                txt_TechEmail_Up.Focus();
            }
            else if (!Regex.IsMatch(txt_TechEmail_Up.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msgTech_Up.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_TechEmail_Up.Focus();
            }
            else if (txt_TechPhone_Up.Text.Length == 0)
            {
                error_msgTech_Up.Text = "Please Enter Teacher Phone No!";
                txt_TechPhone_Up.Focus();
            }
            else if (!Regex.IsMatch(txt_TechPhone_Up.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msgTech_Up.Text = "Telephone No is not Valid";
                txt_TechPhone_Up.Focus();
            }
            else if (txt_TechNIC_Up.Text.Length == 0)
            {
                error_msgTech_Up.Text = "Please Enter Teacher NIC!";
                txt_TechNIC_Up.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update teacher set fname= '" + txt_TechName_Up.Text + "',lname= '" + txt_TechName_Up2.Text + "', t_address= '" + txt_TechAddress_Up.Text + "', dob= '" + dobPicker2.Value + "', t_email= '" + txt_TechEmail_Up.Text + "', mobile= '" + txt_TechPhone_Up.Text + "', nic= '" + txt_TechNIC_Up.Text + "'  where t_id= '" + txt_TechId_Up.Text + "' ", con);
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
                txt_TechId_Up.Clear();
                txt_TechName_Up.Clear();
                txt_TechName_Up2.Clear();
                txt_TechAddress_Up.Clear();
                dobPicker2.ResetText();
                txt_TechEmail_Up.Clear();
                txt_TechPhone_Up.Clear();
                txt_TechNIC_Up.Clear();
                error_msgTech_Up.ResetText();
            }
        }
        private void btnTechUpClear_Click(object sender, EventArgs e)
        {
            txt_TechId_Up.Clear();
            txt_TechName_Up.Clear();
            txt_TechName_Up2.Clear();
            txt_TechAddress_Up.Clear();
            dobPicker2.ResetText();
            txt_TechEmail_Up.Clear();
            txt_TechPhone_Up.Clear();
            txt_TechNIC_Up.Clear();
            error_msgTech_Up.ResetText();
        }

        private void btnTechUpCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //DELETE
        private void btnTechDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TechId_Del.Text))
            {
                error_msgTech_Del.Text = "Please Enter Teacher Id!";
                txt_TechId_Del.Focus();
            }
            else if (txt_TechId_Del.Text.Any(char.IsLetter))
            {
                error_msgTech_Del.Text = "Teacher Id Can not Have Characters!";
                txt_TechId_Del.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from teacher where t_id = '" + txt_TechId_Del.Text + "'", con);
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
                txt_TechId_Del.Clear();
                error_msgTech_Del.ResetText();
            }
        }

        private void btnTechDelClear_Click(object sender, EventArgs e)
        {
            txt_TechId_Del.Clear();
            error_msgTech_Del.ResetText();
        }

        private void btnTechDelCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //VIEW
        private void btnTechView_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_TechId.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from teacher where t_id = '" + txt_Tech_View1.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (rbt_TechNIC.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from teacher where nic LIKE '" + txt_Tech_View1.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                if (txt_Tech_View1.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from teacher", con);
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
            txt_Tech_View1.Clear();
        }

        private void btnTechView_Cancel_Click(object sender, EventArgs e)
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
