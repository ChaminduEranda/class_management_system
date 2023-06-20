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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();          
        }

        String Role;
        public frmStudent(string r)
        {
            InitializeComponent();
            Role = r;
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmStudent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
            dobPicker1.Value = DateTime.Today;
            dobPicker2.Value = DateTime.Today;

            SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(s_id as int)),0)+1 FROM student ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txt_StId.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_StName;

            if(Role=="INS")
            {
                btnStCancel.Hide();
                btnStUpCancel.Hide();
                btnStDelCancel.Hide();
                btnStView_Cancel.Hide();
            }
            else
            {
                lbl_Back.Hide();
            }
        }
        private void btnStSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_StId.Text))
            {
                error_msgST.Text = "Please Enter Student Id!";
                txt_StId.Focus();
            }
            else if ((txt_StId.Text.Any(char.IsLetter)))
            {
                error_msgST.Text = "Student Id Can not Have Characters!";
                txt_StId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_StName.Text))
            {
                error_msgST.Text = "Please Enter First Name!";
                txt_StName.Focus();
            }
            else if (txt_StName.Text.Any(char.IsDigit))
            {
                error_msgST.Text = "First Name cannot have Numbers!";
                txt_StName.Focus();
            }
            else if (string.IsNullOrEmpty(txt_StName2.Text))
            {
                error_msgST.Text = "Please Enter Last Name!";
                txt_StName2.Focus();
            }
            else if (txt_StName2.Text.Any(char.IsDigit))
            {
                error_msgST.Text = "Last Name cannot have Numbers!";
                txt_StName2.Focus();
            }
            else if (string.IsNullOrEmpty(txt_StAddress.Text))
            {
                error_msgST.Text = "Please Enter Student Address!";
                txt_StAddress.Focus();
            }
            else if (dobPicker1.Value>=DateTime.Today)
            {
               
                error_msgST.Text = "Please Select Student's Birthday Correctly!";
                dobPicker1.Focus();
            }
            else if (txt_StEmail.Text.Length == 0)
            {
                error_msgST.Text = "Please Enter Student Email Address";
                txt_StEmail.Focus();
            }
            else if (!Regex.IsMatch(txt_StEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msgST.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_StEmail.Focus();
            }
            else if (txt_StPhone.Text.Length == 0)
            {
                error_msgST.Text = "Please Enter Student Phone No";
                txt_StPhone.Focus();
            }
            else if (!Regex.IsMatch(txt_StPhone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msgST.Text = "Contact No is not Valid";
                txt_StPhone.Focus();
            }
            else if (cmb_StGender.SelectedIndex==-1)
            {
                error_msgST.Text = "Please Select a Gender!";
                cmb_StGender.Focus();
            }
            else if (txt_StNIC.Text.Length == 0)
            {
                error_msgST.Text = "Please Enter Student NIC!";
                txt_StNIC.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into student values ('" + txt_StId.Text + "', '" + txt_StName.Text + "','" + txt_StName2.Text + "', '" + txt_StAddress.Text + "',  '" + dobPicker1.Value + "', '" + txt_StEmail.Text + "', '" + txt_StPhone.Text + "', '" + cmb_StGender.SelectedItem + "', '" + txt_StNIC.Text + "') ", con);
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
                //txt_StId.Clear();
                txt_StName.Clear();
                txt_StName2.Clear();
                txt_StAddress.Clear();
                dobPicker1.ResetText();
                txt_StEmail.Clear();
                txt_StPhone.Clear();
                cmb_StGender.SelectedItem = null;
                txt_StNIC.Clear();
                error_msgST.ResetText();

                SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(s_id as int)),0)+1 FROM student ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_StId.Text = dt.Rows[0][0].ToString();
                this.ActiveControl = txt_StName;
            }
        }
        private void btnStClear_Click(object sender, EventArgs e)
        {
            //txt_StId.Clear();
            txt_StName.Clear();
            txt_StName2.Clear();
            txt_StAddress.Clear();
            dobPicker1.ResetText();
            txt_StEmail.Clear();
            txt_StPhone.Clear();
            cmb_StGender.SelectedItem = null;
            txt_StNIC.Clear();
            error_msgST.ResetText();
        }

        private void btnStCancel_Click(object sender, EventArgs e)
        {
            Hide();
           frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //UPDATE
        private void btnStUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_StId_Up.Text))
            {
                error_msgST_Up.Text = "Please Enter Student Id!";
                txt_StId_Up.Focus();
            }
            else if ((txt_StId_Up.Text.Any(char.IsLetter)))
            {
                error_msgST_Up.Text = "Student Id Can not Have Characters!";
                txt_StId_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_StName_Up.Text))
            {
                error_msgST_Up.Text = "Please Enter First Name!";
                txt_StName_Up.Focus();
            }
            else if (txt_StName_Up.Text.Any(char.IsDigit))
            {
                error_msgST_Up.Text = "First Name cannot have Numbers!";
                txt_StName_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_StName_Up2.Text))
            {
                error_msgST_Up.Text = "Please Enter Last Name!";
                txt_StName_Up2.Focus();
            }
            else if (txt_StName_Up2.Text.Any(char.IsDigit))
            {
                error_msgST_Up.Text = "Last Name cannot have Numbers!";
                txt_StName_Up2.Focus();
            }
            else if (string.IsNullOrEmpty(txt_StAddress_Up.Text))
            {
                error_msgST_Up.Text = "Please Enter Student Address!";
                txt_StAddress_Up.Focus();
            }
            else if (DateTime.Today <= dobPicker2.Value)
            {
                error_msgST_Up.Text = "Please Select Student's Birthday Correctly!";
                dobPicker2.Focus();
            }
            else if (txt_StEmail_Up.Text.Length == 0)
            {
                error_msgST_Up.Text = "Please Enter Student Email Address";
                txt_StEmail_Up.Focus();
            }
            else if (!Regex.IsMatch(txt_StEmail_Up.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msgST_Up.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_StEmail_Up.Focus();
            }
            else if (txt_StPhone_Up.Text.Length == 0)
            {
                error_msgST_Up.Text = "Please Enter Student Phone No";
                txt_StPhone_Up.Focus();
            }
            else if (!Regex.IsMatch(txt_StPhone_Up.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msgST_Up.Text = "Contact No is not Valid";
                txt_StPhone_Up.Focus();
            }
            else if (cmb_StGender_Up.SelectedIndex==-1)
            {
                error_msgST_Up.Text = "Please Select a Gender!";
                cmb_StGender_Up.Focus();
            }
            else if (txt_StNIC_Up.Text.Length == 0)
            {
                error_msgST_Up.Text = "Please Enter Student NIC!";
                txt_StNIC_Up.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update student set fname= '" + txt_StName_Up.Text + "',lname= '" + txt_StName_Up2.Text + "', s_address= '" + txt_StAddress_Up.Text + "', dob=  '" + dobPicker2.Value + "', s_email= '" + txt_StEmail_Up.Text + "', mobile= '" + txt_StPhone_Up.Text + "', gender= '" + cmb_StGender_Up.SelectedItem + "', nic= '" +txt_StNIC_Up.Text + "' where s_id= '" + txt_StId_Up.Text + "' ", con);
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
                txt_StId_Up.Clear();
                txt_StName_Up.Clear();
                txt_StName_Up2.Clear();
                txt_StAddress_Up.Clear();
                dobPicker2.ResetText();
                txt_StEmail_Up.Clear();
                txt_StPhone_Up.Clear();
                cmb_StGender_Up.SelectedItem = null;
                txt_StNIC_Up.Clear();
                error_msgST_Up.ResetText();
            }
        }
        private void btnStUpClear_Click(object sender, EventArgs e)
        {
            txt_StId_Up.Clear();
            txt_StName_Up.Clear();
            txt_StName_Up2.Clear();
            txt_StAddress_Up.Clear();
            dobPicker2.ResetText();
            txt_StEmail_Up.Clear();
            txt_StPhone_Up.Clear();
            cmb_StGender_Up.SelectedItem = null;
            txt_StNIC_Up.Clear();
            error_msgST_Up.ResetText();
        }

        private void btnStUpCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        
        }


        //DELETE
        private void btnStDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_StId_Del.Text))
            {
                error_msgST_Del.Text = "Please Enter Student Id!";
                txt_StId_Del.Focus();
            }
            else if ((txt_StId_Del.Text.Any(char.IsLetter)))
            {
                error_msgST_Del.Text = "Student Id Can not Have Characters!";
                txt_StId_Del.Focus();
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from student where s_id = '" + txt_StId_Del.Text + "'", con);
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
                txt_StId_Del.Clear();
                error_msgST_Del.ResetText();
            }
        }
        private void btnStDelClear_Click(object sender, EventArgs e)
        {
            txt_StId_Del.Clear();
            error_msgST_Del.ResetText();
        }

        private void btnStDelCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //VIEW
        private void btnStView_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (rbt_StId.Checked == true)
                    {
                        con.Open();
                        da = new SqlDataAdapter("Select * from student where s_id = '" + txt_St_View.Text + "'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        con.Close();
                    }
                    else if (rbt_NIC.Checked == true)
                    {
                        con.Open();
                        da = new SqlDataAdapter("Select * from student where nic LIKE '" + txt_St_View.Text + "%'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        con.Close();
                    }
                    if (txt_St_View.Text.Length == 0)
                    {
                        con.Open();
                        da = new SqlDataAdapter("Select * from student", con);
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
                txt_St_View.Clear();
                
            
        }
        private void btnStView_Cancel_Click(object sender, EventArgs e)
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
