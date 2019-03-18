using GCFamily.DTO;
using GCFamily.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCFamily
{
    public partial class FDashboard : Form
    {
        public FDashboard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Employee> employees = DataProvider.GetInstance().getEmployees();

            employees.ForEach(item => {
                EmployeeForm employeeForm = new EmployeeForm(item);                
                employeeContainer.Controls.Add(employeeForm);
            });                
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void l_Load(object sender, EventArgs e)
        {
            Employee user = DataProvider.GetInstance().getUser();
            lbUsername.Text = user.FirstName + " " + user.LastName;
        }

        private void FDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
