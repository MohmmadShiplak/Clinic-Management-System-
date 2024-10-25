namespace Clinic_Management_system
{
    partial class frmShowDoctorsInfo
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
            this.ctrlDoctorCard1 = new Clinic_Management_system.ctrlDoctorCard();
            this.SuspendLayout();
            // 
            // ctrlDoctorCard1
            // 
            this.ctrlDoctorCard1.BackColor = System.Drawing.Color.White;
            this.ctrlDoctorCard1.Location = new System.Drawing.Point(-2, -6);
            this.ctrlDoctorCard1.Name = "ctrlDoctorCard1";
            this.ctrlDoctorCard1.Size = new System.Drawing.Size(1107, 628);
            this.ctrlDoctorCard1.TabIndex = 0;
            // 
            // frmShowDoctorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 622);
            this.Controls.Add(this.ctrlDoctorCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowDoctorsInfo";
            this.Text = "Show Doctors Info";
            this.Load += new System.EventHandler(this.frmShowDoctorsInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDoctorCard ctrlDoctorCard1;
    }
}