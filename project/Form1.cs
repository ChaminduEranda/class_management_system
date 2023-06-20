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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
            
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_logName.Text))
            {
                error_msg1.Text = "Please Enter Your Username!";
                txt_logName.Focus();
            }

            else if (txt_logPassword.Text.Length == 0)
            {
                error_msg1.Text = "Please Enter your Password!";
                txt_logPassword.Focus();
            }
            else if (cmb_logType.SelectedIndex == -1)
            {
                error_msg1.Text = "Please Select a User Role!";
                cmb_logType.Focus();
            }
            else
            {

                cmd = new SqlCommand("select *from app_user where u_username='" + txt_logName.Text + "' AND u_password=HASHBYTES('md5', '" + txt_logPassword.Text + "') AND u_role='" + cmb_logType.SelectedItem + "' ", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string cmbItemValue = cmb_logType.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][2].ToString() == cmbItemValue)
                        {
                            MetroFramework.MetroMessageBox.Show(this,"Logged as a " + dt.Rows[i][2],"infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (cmb_logType.SelectedIndex == 0)
                            {
                                this.Hide();
                               frm_HomePage  T = new frm_HomePage();
                                T.Show();
                            }
                            else
                            {
                                this.Hide();
                               HomePage_INS T = new HomePage_INS();
                                T.Show();
                            }
                        }
                    }

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Invalid Username,Password or User Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

       

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
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

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Link_Att1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Attendance obj = new frm_Attendance();
            obj.Show();
        }
    }
}
