﻿namespace Clinic_Management_system
{
    partial class frmShowPatientInfo
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
            this.ctrlPatientCard1 = new Clinic_Management_system.ctrlPatientCard();
            this.SuspendLayout();
            // 
            // ctrlPatientCard1
            // 
            this.ctrlPatientCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPatientCard1.Location = new System.Drawing.Point(-3, -1);
            this.ctrlPatientCard1.Name = "ctrlPatientCard1";
            this.ctrlPatientCard1.Size = new System.Drawing.Size(1041, 662);
            this.ctrlPatientCard1.TabIndex = 0;
            // 
            // frmShowPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 653);
            this.Controls.Add(this.ctrlPatientCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPatientInfo";
            this.Text = "frmShowPatientInfo";
            this.Load += new System.EventHandler(this.frmShowPatientInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPatientCard ctrlPatientCard1;
    }
}