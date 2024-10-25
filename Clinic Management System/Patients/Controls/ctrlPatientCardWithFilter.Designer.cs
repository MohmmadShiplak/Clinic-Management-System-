namespace Clinic_Management_system
{
    partial class ctrlPatientCardWithFilter
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
            this.ctrlPatientCard1 = new Clinic_Management_system.ctrlPatientCard();
            this.ctrlFilter1 = new Clinic_Management_system.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlPatientCard1
            // 
            this.ctrlPatientCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPatientCard1.Location = new System.Drawing.Point(3, 110);
            this.ctrlPatientCard1.Name = "ctrlPatientCard1";
            this.ctrlPatientCard1.Size = new System.Drawing.Size(1054, 621);
            this.ctrlPatientCard1.TabIndex = 1;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.ShowAddPersonButton = true;
            this.ctrlFilter1.Size = new System.Drawing.Size(1051, 116);
            this.ctrlFilter1.TabIndex = 0;
            this.ctrlFilter1.TextSearch = "";
            this.ctrlFilter1.OnFindNumericClick += new System.EventHandler<Clinic_Management_system.ctrlFilter.FindNumericClickEventArgs>(this.ctrlFilter1_OnFindNumericClick);
            // 
            // ctrlPatientCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPatientCard1);
            this.Controls.Add(this.ctrlFilter1);
            this.Name = "ctrlPatientCardWithFilter";
            this.Size = new System.Drawing.Size(1054, 757);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFilter ctrlFilter1;
        private ctrlPatientCard ctrlPatientCard1;
    }
}
