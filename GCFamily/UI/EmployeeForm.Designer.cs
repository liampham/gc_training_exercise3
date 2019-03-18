namespace GCFamily
{
    partial class EmployeeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imgEmployeeAvatar = new GCFamily.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmployeeAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(10, 173);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(218, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "User Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lbPosition.Location = new System.Drawing.Point(10, 205);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(218, 30);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "Position";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPosition.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgEmployeeAvatar
            // 
            this.imgEmployeeAvatar.Image = global::GCFamily.Properties.Resources.avatar;
            this.imgEmployeeAvatar.Location = new System.Drawing.Point(40, 10);
            this.imgEmployeeAvatar.Name = "imgEmployeeAvatar";
            this.imgEmployeeAvatar.Size = new System.Drawing.Size(160, 160);
            this.imgEmployeeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEmployeeAvatar.TabIndex = 3;
            this.imgEmployeeAvatar.TabStop = false;
            this.imgEmployeeAvatar.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgEmployeeAvatar);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbName);
            this.Name = "EmployeeForm";
            this.Size = new System.Drawing.Size(240, 240);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEmployeeAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPosition;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularPictureBox imgEmployeeAvatar;
    }
}
