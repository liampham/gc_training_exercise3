namespace GCFamily
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GCFamily.DTO.Employee employee1 = new GCFamily.DTO.Employee();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.employeeProfile1 = new GCFamily.EmployeeProfile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeProfile1
            // 
            this.employeeProfile1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            employee1.Avatar = "";
            employee1.EmployeeID = "";
            employee1.FirstName = "";
            employee1.LastName = "";
            employee1.Outlook = "";
            employee1.Position = "";
            employee1.PrivateKey = "";
            employee1.Profile = "";
            employee1.Skype = "";
            this.employeeProfile1.Employee = employee1;
            this.employeeProfile1.Location = new System.Drawing.Point(122, 31);
            this.employeeProfile1.Name = "employeeProfile1";
            this.employeeProfile1.Size = new System.Drawing.Size(910, 614);
            this.employeeProfile1.TabIndex = 1;
            this.employeeProfile1.Load += new System.EventHandler(this.employeeProfile1_Load);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1125, 686);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 686);
            this.Controls.Add(this.employeeProfile1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EmployeeProfile employeeProfile1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}