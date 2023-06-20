using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using ZXing;
using System.Data.SqlClient;

namespace project
{
    public partial class frm_Attendance : Form
    {
        public frm_Attendance()
        {
            InitializeComponent();
        }

        String Role;
        public frm_Attendance(string r)
        {
            InitializeComponent();
            Role = r;
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        string con_string = "Data Source=DESKTOP-SITAVPT;Initial Catalog=class;Integrated Security=True";

        private void frm_Attendance_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cmbDevice.Items.Add(filterInfo.Name);
            cmbDevice.SelectedIndex = 0;

            if(Role!="TECH")
            {
                btn_Cancel.Hide();
                btn_Cancel_Att.Hide();
                btnGenerate.Hide();
                label1.Hide();
                textBox2.Hide();
                pictureBox1.Hide();
            }
            else
            {
                link_ToLogin1.Hide();
            }
        }

        private void btn__Start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cmbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        } 
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image);
                if (result != null)
                {
                    textBox3.Text = result.ToString();
                    timer1.Stop();
                    //if (captureDevice.IsRunning)
                    //  captureDevice.Stop();
                    SqlConnection connection = new SqlConnection(con_string);
                    SqlCommand command = connection.CreateCommand();
                    connection.Open();
                    command.CommandText = "INSERT INTO attendance (student_id) VALUES (@student_id);";
                    command.Parameters.AddWithValue("@student_id", result.ToString());
                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Attendance was succesfully recorded for ID: " + result.ToString());
                        }
                    }
                    catch (SqlException)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please Check the Student ID again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "This student does not exist in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    pictureBox2.Image = null;
                    connection.Close();
                }
            }



        }
        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {

            Hide();
            frm_HomePage obj = new frm_HomePage();
            obj.Show();
        }

        private void btn_Cancel_Att_Click(object sender, EventArgs e)
        {
            if (captureDevice == null)
            {
                Hide();
                frm_HomePage obj = new frm_HomePage();
                obj.Show();

            }
            else
            {
                captureDevice.Stop();
                Hide();
                frm_HomePage obj = new frm_HomePage();
                obj.Show();
            }
        }



        //QR Generator
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                error_msg2.Text = "Please Enter Student Id!";
                textBox2.Focus();
            }
            else
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(textBox2.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pictureBox1.Image = code.GetGraphic(5);
            }
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

        private void frm_Attendance_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (captureDevice == null)
            {
                Application.Exit();

            }
            else
            {
                captureDevice.Stop();
                Application.Exit();
            }
        }

        private void link_ToLogin1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (captureDevice == null)
            {
                Hide();
                frmLogin obj = new frmLogin();
                obj.Show();

            }
            else
            {
                captureDevice.Stop();
                Hide();
                frmLogin obj = new frmLogin();
                obj.Show();
            }

           
        }
    }

}
