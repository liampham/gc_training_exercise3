using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCFamily.DTO;
using GCFamily.Utilities;

namespace GCFamily
{
    public partial class EmployeeProfile : UserControl
    {
        private Employee employee;

        public Employee Employee { get => employee; set => employee = value; }

        public EmployeeProfile(Employee employee)
        {
            this.Employee = employee;
            InitializeComponent();
        }

        public EmployeeProfile()
        {
            this.Employee = new Employee();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            lbUsername.Text = Employee.FirstName + " " + Employee.LastName;
            lbPosition.Text = Employee.Position;
            lbSkype.Text = Employee.Skype;
            lbOutlook.Text = Employee.Outlook;
            this.setEmployeeImage(Employee.Avatar);

            Task.Delay(500).ContinueWith(t => this.loadEmployeeInfo(Employee.Profile));           
        }
        public void loadEmployeeInfo(String url)
        {

            if (Utils.isEmptyString(url))
            {
                url = "Assets/default.html";
            }
            if (url.StartsWith("http"))
                webview.Navigate(url);
            else
                webview.Navigate(Application.StartupPath + "\\" + url);
           
        }

        public void setEmployeeImage(String url)
        {
            if (Utils.isEmptyString(url)) return;
            try
            {
                if (url.StartsWith("http"))
                {
                    this.imgAvatar.ImageLocation = url;
                }
                else
                {
                    Console.WriteLine("Startup path" + Application.StartupPath + url);
                    this.imgAvatar.Image = System.Drawing.Image.FromFile(Application.StartupPath + "\\" + url);
                }
            }
            catch
            {

            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
