using GCFamily.Constants;
using GCFamily.Providers;
using GCFamily.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GCFamily.Service.AuthenticationService;

namespace GCFamily
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataProvider dataProvider = DataProvider.GetInstance();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void onClickLogin(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            AuthenticationResponse response =  AuthenticationService.Authenticate(username, password);
            if (response.ResultCode == ResultCode.FAIL) {
                MessageBox.Show(response.Message,Messages.LOGIN_FAIL);
            }
            else
            {
                DataProvider.GetInstance().setUserID(username);
                FDashboard dashboard = new FDashboard();
                dashboard.Show();
                Hide();
            }

            
        }

        private void placeHolderTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
