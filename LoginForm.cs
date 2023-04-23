using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIndowFormApp8910
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


            string username = usernamebox.Text;
            string password = passwordbox.Text;

        
            bool isValid = true;

            if (isValid)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                if (usernamebox.Text == "")
                {
                    MessageBox.Show("Please enter your username/password to continue.");
                    return;
                }
                if (passwordbox.Text == "")
                {
                    MessageBox.Show("Please enter your username/password to continue.");
                    return;
                }
            }

        }

        private void Below_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=nsrdScMVSjA&ab_channel=shims");
        }

        private void tooltip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            Application.Exit();
        }
    }
}
