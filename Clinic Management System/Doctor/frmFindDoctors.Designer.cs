namespace Clinic_Management_system
{
    partial class frmFindDoctors
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
            this.ctrlDoctorCardWithFilter1 = new Clinic_Management_system.ctrlDoctorCardWithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlDoctorCardWithFilter1
            // 
            this.ctrlDoctorCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDoctorCardWithFilter1.FilterEnabled = true;
            this.ctrlDoctorCardWithFilter1.Location = new System.Drawing.Point(-4, -10);
            this.ctrlDoctorCardWithFilter1.Name = "ctrlDoctorCardWithFilter1";
            this.ctrlDoctorCardWithFilter1.Size = new System.Drawing.Size(1093, 742);
            this.ctrlDoctorCardWithFilter1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(942, 726);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 49);
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFindDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 779);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDoctorCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindDoctors";
            this.Text = "Find Doctors";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDoctorCardWithFilter ctrlDoctorCardWithFilter1;
        private System.Windows.Forms.Button btnClose;
    }
}