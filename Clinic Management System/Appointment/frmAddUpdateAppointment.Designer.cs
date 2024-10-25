namespace Clinic_Management_system
{
    partial class frmAddUpdateAppointment
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpDoctor = new System.Windows.Forms.TabPage();
            this.ctrlDoctorCardWithFilter2 = new Clinic_Management_system.ctrlDoctorCardWithFilter();
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.ctrlPatientCardWithFilter1 = new Clinic_Management_system.ctrlPatientCardWithFilter();
            this.tpAppointments = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblAppointmentID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TabControl1.SuspendLayout();
            this.tpDoctor.SuspendLayout();
            this.tpPatient.SuspendLayout();
            this.tpAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tpDoctor);
            this.guna2TabControl1.Controls.Add(this.tpPatient);
            this.guna2TabControl1.Controls.Add(this.tpAppointments);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(-14, 8);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1052, 806);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpDoctor
            // 
            this.tpDoctor.Controls.Add(this.ctrlDoctorCardWithFilter2);
            this.tpDoctor.Location = new System.Drawing.Point(4, 44);
            this.tpDoctor.Name = "tpDoctor";
            this.tpDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoctor.Size = new System.Drawing.Size(1044, 758);
            this.tpDoctor.TabIndex = 0;
            this.tpDoctor.Text = "Doctors  Info ";
            this.tpDoctor.UseVisualStyleBackColor = true;
            // 
            // ctrlDoctorCardWithFilter2
            // 
            this.ctrlDoctorCardWithFilter2.BackColor = System.Drawing.Color.White;
            this.ctrlDoctorCardWithFilter2.FilterEnabled = true;
            this.ctrlDoctorCardWithFilter2.Location = new System.Drawing.Point(6, -5);
            this.ctrlDoctorCardWithFilter2.Name = "ctrlDoctorCardWithFilter2";
            this.ctrlDoctorCardWithFilter2.Size = new System.Drawing.Size(1032, 757);
            this.ctrlDoctorCardWithFilter2.TabIndex = 0;
            // 
            // tpPatient
            // 
            this.tpPatient.Controls.Add(this.ctrlPatientCardWithFilter1);
            this.tpPatient.Location = new System.Drawing.Point(4, 44);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(1044, 758);
            this.tpPatient.TabIndex = 1;
            this.tpPatient.Text = "Patients  Info ";
            this.tpPatient.UseVisualStyleBackColor = true;
            // 
            // ctrlPatientCardWithFilter1
            // 
            this.ctrlPatientCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPatientCardWithFilter1.FilterEnabled = true;
            this.ctrlPatientCardWithFilter1.Location = new System.Drawing.Point(6, -5);
            this.ctrlPatientCardWithFilter1.Name = "ctrlPatientCardWithFilter1";
            this.ctrlPatientCardWithFilter1.Size = new System.Drawing.Size(1038, 757);
            this.ctrlPatientCardWithFilter1.TabIndex = 0;
            this.ctrlPatientCardWithFilter1.OnePatientSelected += new System.EventHandler<Clinic_Management_system.ctrlPatientCardWithFilter.clsPatientSelectedEventArgs>(this.ctrlPatientCardWithFilter1_OnePatientSelected_3);
            // 
            // tpAppointments
            // 
            this.tpAppointments.Controls.Add(this.btnClose);
            this.tpAppointments.Controls.Add(this.btSave);
            this.tpAppointments.Controls.Add(this.label3);
            this.tpAppointments.Controls.Add(this.label2);
            this.tpAppointments.Controls.Add(this.label1);
            this.tpAppointments.Controls.Add(this.dtpTime);
            this.tpAppointments.Controls.Add(this.cbStatus);
            this.tpAppointments.Controls.Add(this.lblAppointmentID);
            this.tpAppointments.Location = new System.Drawing.Point(4, 44);
            this.tpAppointments.Name = "tpAppointments";
            this.tpAppointments.Size = new System.Drawing.Size(1044, 758);
            this.tpAppointments.TabIndex = 2;
            this.tpAppointments.Text = "Appointments Info ";
            this.tpAppointments.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(742, 721);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 37);
            this.btnClose.TabIndex = 214;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(906, 721);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(134, 37);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Save ";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 213;
            this.label3.Text = "Status  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 212;
            this.label2.Text = "Appointment Time  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 211;
            this.label1.Text = "Appointment ID :";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm:tt";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(262, 155);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(133, 27);
            this.dtpTime.TabIndex = 210;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbStatus.BorderRadius = 17;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Location = new System.Drawing.Point(261, 218);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(211, 36);
            this.cbStatus.TabIndex = 209;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointmentID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(261, 85);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(30, 30);
            this.lblAppointmentID.TabIndex = 207;
            this.lblAppointmentID.Text = "???";
            // 
            // frmAddUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 812);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateAppointment";
            this.Text = "Add Update Appointment";
            this.Load += new System.EventHandler(this.frmAddUpdateAppointment_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tpDoctor.ResumeLayout(false);
            this.tpPatient.ResumeLayout(false);
            this.tpAppointments.ResumeLayout(false);
            this.tpAppointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tpDoctor;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.TabPage tpAppointments;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppointmentID;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btnClose;
        private ctrlDoctorCardWithFilter ctrlDoctorCardWithFilter2;
        private ctrlPatientCardWithFilter ctrlPatientCardWithFilter1;
    }
}