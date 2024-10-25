namespace Clinic_Management_system
{
    partial class ctrlDoctorCardWithFilter
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
            this.ctrlDoctorCard1 = new Clinic_Management_system.ctrlDoctorCard();
            this.ctrlFilter1 = new Clinic_Management_system.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlDoctorCard1
            // 
            this.ctrlDoctorCard1.BackColor = System.Drawing.Color.White;
            this.ctrlDoctorCard1.Location = new System.Drawing.Point(0, 135);
            this.ctrlDoctorCard1.Name = "ctrlDoctorCard1";
            this.ctrlDoctorCard1.Size = new System.Drawing.Size(1087, 622);
            this.ctrlDoctorCard1.TabIndex = 0;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.ShowAddPersonButton = true;
            this.ctrlFilter1.Size = new System.Drawing.Size(1087, 112);
            this.ctrlFilter1.TabIndex = 1;
            this.ctrlFilter1.TextSearch = "";
            this.ctrlFilter1.OnFindNumericClick += new System.EventHandler<Clinic_Management_system.ctrlFilter.FindNumericClickEventArgs>(this.ctrlFilter1_OnFindNumericClick);
            // 
            // ctrlDoctorCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlDoctorCard1);
            this.Name = "ctrlDoctorCardWithFilter";
            this.Size = new System.Drawing.Size(1092, 757);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDoctorCard ctrlDoctorCard1;
        private ctrlFilter ctrlFilter1;
    }
}
