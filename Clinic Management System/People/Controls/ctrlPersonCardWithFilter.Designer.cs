﻿namespace Clinic_Management_system
{
    partial class ctrlPersonCardWithFilter
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
            this.ctrlPersonCard1 = new Clinic_Management_system.ctrlPersonCard();
            this.ctrlFilter1 = new Clinic_Management_system.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 151);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1105, 373);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.ShowAddPersonButton = true;
            this.ctrlFilter1.Size = new System.Drawing.Size(1093, 138);
            this.ctrlFilter1.TabIndex = 0;
            this.ctrlFilter1.TextSearch = "";
            this.ctrlFilter1.OnFindNumericClick += new System.EventHandler<Clinic_Management_system.ctrlFilter.FindNumericClickEventArgs>(this.ctrlFilter1_OnFindNumericClick);
            this.ctrlFilter1.OnAddClick += new System.EventHandler(this.ctrlFilter1_OnAddClick);
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlFilter1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1099, 527);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFilter ctrlFilter1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
