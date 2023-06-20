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
    public partial class frmExamDetails : Form
    {
        public frmExamDetails()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmExamDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True");
            dobPicker1.Value = DateTime.Now;
            dobPicker2.Value = DateTime.Now;

            SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(e_id as int)),0)+1 FROM exam ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txt_ExId.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_ExId;

        }
        private void btnExAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ExId.Text))
            {
                error_msgEX.Text = "Please Enter Exam Id!";
                txt_ExId.Focus();
            }
            else if (txt_ExId.Text.Any(char.IsLetter))
            {
                error_msgEX.Text = "Exam Id Can not Have Characters!";
                txt_ExId.Focus();
            }
            else if (string.IsNullOrEmpty(txt_ExName.Text))
            {
                error_msgEX.Text = "Please Enter Exam Name!";
                txt_ExName.Focus();
            }
            else if (dobPicker1.Value<DateTime.Now)
            {
                error_msgEX.Text = "Please Enter Exam Date Correctly!";
                dobPicker1.Focus();
            }
           else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into exam values ('" + txt_ExId.Text + "', '" + txt_ExName.Text + "', '" + dobPicker1.Value + "') ", con);
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
                //txt_ExId.Clear();
                txt_ExName.Clear();
                dobPicker1.ResetText();
                error_msgEX.ResetText();


                SqlDataAdapter da = new SqlDataAdapter("Select isnull (max(cast(e_id as int)),0)+1 FROM exam ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_ExId.Text = dt.Rows[0][0].ToString();
                this.ActiveControl = txt_ExId;
            }
        }

        private void btnExClear_Click(object sender, EventArgs e)
        {
            //txt_ExId.Clear();
            txt_ExName.Clear();
            dobPicker1.ResetText();
            error_msgEX.ResetText();
        }

        private void btnExCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //UPDATE
        private void btnExUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ExId_Up.Text))
            {
                error_msgEX_Up.Text = "Please Enter Exam Id!";
                txt_ExId_Up.Focus();
            }
            else if (txt_ExId_Up.Text.Any(char.IsLetter))
            {
                error_msgEX_Up.Text = "Exam Id Can not Have Characters!";
                txt_ExId_Up.Focus();
            }
            else if (string.IsNullOrEmpty(txt_ExName_Up.Text))
            {
                error_msgEX_Up.Text = "Please Enter Exam Name!";
                txt_ExName_Up.Focus();
            }
            
           else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update exam set  e_name= '" + txt_ExName_Up.Text + "', e_date= '" + dobPicker2.Value + "' where e_id= '" + txt_ExId_Up.Text + "'", con);
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
                txt_ExId_Up.Clear();
                txt_ExName_Up.Clear();
                dobPicker2.ResetText();
                error_msgEX_Up.ResetText();
            }
        }
        private void btnExUpClear_Click(object sender, EventArgs e)
        {
            txt_ExId_Up.Clear();
            txt_ExName_Up.Clear();
            dobPicker2.ResetText();
            error_msgEX_Up.ResetText();
        }

        private void btnExUpCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }


        //DELETE
        private void btnExDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ex_Delete.Text))
            {
                error_msgEX_Del.Text = "Please Enter Exam Id!";
                txt_Ex_Delete.Focus();
            }
            else if (txt_Ex_Delete.Text.Any(char.IsLetter))
            {
                error_msgEX_Del.Text = "Exam Id Can not Have Characters!";
                txt_Ex_Delete.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from exam where e_id = '" + txt_Ex_Delete.Text + "'", con);
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
                txt_Ex_Delete.Clear();
                error_msgEX_Del.ResetText();
            }
        }

        private void btnExDelClear_Click(object sender, EventArgs e)
        {
            txt_Ex_Delete.Clear();
            error_msgEX_Del.ResetText();
        }

        private void btnExDelCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        //VIEW
        private void btnExView_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbt_ExId.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from exam where e_id = '" + txt_Ex_View.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (rbt_ExName.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from exam where e_name LIKE '" + txt_Ex_View.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                if (txt_Ex_View.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from exam", con);
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
            txt_Ex_View.Clear();
           
        }
        private void btnExView_Cancel_Click(object sender, EventArgs e)
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
