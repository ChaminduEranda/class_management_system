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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmCourse_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
        }
        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnCoAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CoId.Text))
            {
                error_msgCO.Text = "Please Enter Course Id!";
                txt_CoId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoName.Text))
            {
                error_msgCO.Text = "Please Enter Course Name!";
                txt_CoName.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoBatch.Text))
            {
                error_msgCO.Text = "Please Enter Course Batch!";
                txt_CoBatch.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoDuration.Text))
            {
                error_msgCO.Text = "Please Enter Course Duration!";
                txt_CoDuration.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoPrice.Text))
            {
                error_msgCO.Text = "Please Enter Course Price!";
                txt_CoPrice.Focus();
            }
            else if (txt_CoPrice.Text.Any(char.IsLetter))
            {
                error_msgCO.Text = "Price cannot have Characters";
                txt_CoPrice.Focus();
            }

            else if (cmb_CoType.SelectedIndex==-1)
            {
                error_msgCO.Text = "Please Enter Course Type!";
                cmb_CoType.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into course values ('" + txt_CoId.Text + "', '" + txt_CoName.Text + "','" + txt_CoBatch.Text + "', '" + txt_CoDuration.Text + "',  '" + txt_CoPrice.Text + "', '" + cmb_CoType.SelectedItem + "') ", con);
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
                txt_CoId.Clear();
                txt_CoName.Clear();
                txt_CoBatch.Clear();
                txt_CoDuration.Clear();
                txt_CoPrice.Clear();
                cmb_CoType.SelectedItem = null;
                error_msgCO.ResetText();
            }
        }
        private void btnCoClear_Click(object sender, EventArgs e)
        {
            txt_CoId.Clear();
            txt_CoName.Clear();
            txt_CoBatch.Clear();
            txt_CoDuration.Clear();
            txt_CoPrice.Clear();
            cmb_CoType.SelectedItem = null;
            error_msgCO.ResetText();
        }

        private void btnCoCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //UPDATE
        private void btnCoUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CoId_Up.Text))
            {
                error_msgCO_Up.Text = "Please Enter Course Id!";
                txt_CoId_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoName_Up.Text))
            {
                error_msgCO_Up.Text = "Please Enter Course Name!";
                txt_CoName_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoBatch_Up.Text))
            {
                error_msgCO_Up.Text = "Please Enter Course Batch!";
                txt_CoBatch_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoDuration_Up.Text))
            {
                error_msgCO_Up.Text = "Please Enter Course Duration!";
                txt_CoDuration_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoPrice_Up.Text))
            {
                error_msgCO_Up.Text = "Please Enter Course price!";
                txt_CoPrice_Up.Focus();
            }
            else if (!(txt_CoPrice_Up.Text.Any(char.IsDigit)))
            {
                error_msgCO_Up.Text = "Price cannot have Characters";
                txt_CoPrice_Up.Focus();
            }

            else if (cmb_CoType_Up.SelectedIndex==-1)
            {
                error_msgCO_Up.Text = "Please Enter Course Type!";
                cmb_CoType_Up.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update course set  c_name= '" + txt_CoName_Up.Text + "',batch= '" + txt_CoBatch_Up.Text + "', duration= '" + txt_CoDuration_Up.Text + "', price=  '" + txt_CoPrice_Up.Text + "', c_type= '" + cmb_CoType_Up.SelectedItem + "'  where c_id= '" + txt_CoId_Up.Text + "'", con);
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
                txt_CoId_Up.Clear();
                txt_CoName_Up.Clear();
                txt_CoBatch_Up.Clear();
                txt_CoDuration_Up.Clear();
                txt_CoPrice_Up.Clear();
                cmb_CoType_Up.SelectedItem=null;
                error_msgCO_Up.ResetText();
            }
        }
        private void btnCoUpClear_Click(object sender, EventArgs e)
        {
            txt_CoId_Up.Clear();
            txt_CoName_Up.Clear();
            txt_CoBatch_Up.Clear();
            txt_CoDuration_Up.Clear();
            txt_CoPrice_Up.Clear();
            cmb_CoType_Up.SelectedItem = null;
            error_msgCO_Up.ResetText();
        }

        private void btnCoUpCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //DELETE
        private void btnCoDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CoId_Del.Text))
            {
                error_msgCO_Del.Text = "Please Enter Course Id!";
                txt_CoId_Del.Focus();
            }
            else if (string.IsNullOrEmpty(txt_CoBatch_Del.Text))
            {
                error_msgCO_Del.Text = "Please Enter Course Id!";
                txt_CoBatch_Del.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from course where c_id = '" + txt_CoId_Del.Text + "' AND batch = '" + txt_CoBatch_Del.Text + "' ", con);
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
                txt_CoId_Del.Clear();
                txt_CoBatch_Del.Clear();
                error_msgCO_Del.ResetText();
            }
        }

        private void btnCoDelClear_Click(object sender, EventArgs e)
        {
            txt_CoId_Del.Clear();
            error_msgCO_Del.ResetText();
        }

        private void btnCoDelCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //VIEW
        private void btnCoView_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_CoId.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from course where c_id = '" + txt_Co_View.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (rbt_CoName.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from course where c_name LIKE '" + txt_Co_View.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                if (txt_Co_View.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from course", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                txt_Co_View.Clear();
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_Co_View.Clear();
            
        }

    private void btnCoView_Cancel_Click(object sender, EventArgs e)
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

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
