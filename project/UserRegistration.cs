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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
       

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

           if (string.IsNullOrEmpty(txt_Username.Text))
            {
                error_msg2.Text = "Please Enter Your Username!";
                txt_Username.Focus();
            }
           
            else if (txtUserPassword.Text.Length == 0)
            {
                error_msg2.Text = "Please Enter your Password!";
                txtUserPassword.Focus();
            }
            else if (txt_UserConPassword.Text.Length == 0)
            {
                error_msg2.Text = "Please Enter Your Confirm Password!";
                txt_UserConPassword.Focus();
            }
            else if (txtUserPassword.Text != txt_UserConPassword.Text)
            {
                error_msg2.Text = "Password Is Not Matched!";
                txt_UserConPassword.Focus();
            }
            else if (cmb_UserRole.SelectedIndex==-1)
            {
                error_msg2.Text = "Please Select a User Role!";
                cmb_UserRole.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into app_user values ('" + txt_Username.Text + "', HASHBYTES('md5',  '" + txt_UserConPassword.Text + "'),  '" + cmb_UserRole.SelectedItem + "') ", con);
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

                
                txt_Username.Clear();
                txtUserPassword.Clear();
                txt_UserConPassword.Clear();
                cmb_UserRole.SelectedItem = null;
                error_msg2.ResetText();
            }
        }

        private void link_ToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            frmLogin obj = new frmLogin();
            obj.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            
            
            txt_Username.Clear();
            txtUserPassword.Clear();
            txt_UserConPassword.Clear();
            cmb_UserRole.SelectedItem = null;
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
