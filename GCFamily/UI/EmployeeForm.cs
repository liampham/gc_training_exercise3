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
    public partial class EmployeeForm : UserControl
    {

        private Employee employee;

        public Employee Employee { get => employee; set => employee = value; }

        public EmployeeForm(Employee employee)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Employee = employee;
            InitializeComponent();
        }
      
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);         
            this.setEmployeeName($"{Employee.FirstName} {Employee.LastName}");
            this.setEmployeeImage(Employee.Avatar);
            this.setEmployeePosition(Employee.Position);
          
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls.RemoveByKey("EmployeeProfile");
          
            EmployeeProfile profile = new EmployeeProfile(this.Employee);
            this.ParentForm.Controls.Add(profile);
            profile.Location = new Point(ParentForm.Width / 2 - profile.Size.Width / 2, ParentForm.Size.Height / 2 - profile.Size.Height / 2);
            profile.BringToFront();
            profile.Name = "EmployeeProfile";
            
        }

        public void setEmployeeName(String employeeName)
        {
            this.lbName.Text = employeeName;
        }
        public void setEmployeePosition(String position)
        {
            this.lbPosition.Text = position;
        }

        public void setEmployeeImage(String url)
        {
            if (Utils.isEmptyString(url)) return;
            try
            {
                if (url.StartsWith("http"))
                {
                    this.imgEmployeeAvatar.ImageLocation = url;
                }
                else
                {                 
                    this.imgEmployeeAvatar.Image = System.Drawing.Image.FromFile(Application.StartupPath + "\\" + url);
                }
            }
            catch
            {

            }
           
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
