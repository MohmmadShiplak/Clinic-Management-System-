namespace Clinic_Management_system
{
    partial class frmListPrescription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsPrescription = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.addNewPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.cmsPrescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.AllowUserToOrderColumns = true;
            this.dgvPrescriptions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrescriptions.ColumnHeadersHeight = 29;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrescriptions.ContextMenuStrip = this.cmsPrescription;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrescriptions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvPrescriptions.Location = new System.Drawing.Point(0, 169);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersVisible = false;
            this.dgvPrescriptions.RowHeadersWidth = 51;
            this.dgvPrescriptions.RowTemplate.Height = 24;
            this.dgvPrescriptions.ShowCellToolTips = false;
            this.dgvPrescriptions.Size = new System.Drawing.Size(1293, 531);
            this.dgvPrescriptions.TabIndex = 6;
            this.dgvPrescriptions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrescriptions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvPrescriptions.ThemeStyle.ReadOnly = false;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvPrescriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvPrescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsPrescription
            // 
            this.cmsPrescription.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPrescription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPrescriptionToolStripMenuItem,
            this.updatePrescriptionToolStripMenuItem,
            this.deletePrescriptionToolStripMenuItem});
            this.cmsPrescription.Name = "cmsPrescription";
            this.cmsPrescription.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsPrescription.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsPrescription.RenderStyle.ColorTable = null;
            this.cmsPrescription.RenderStyle.RoundedEdges = true;
            this.cmsPrescription.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsPrescription.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsPrescription.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsPrescription.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsPrescription.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsPrescription.Size = new System.Drawing.Size(223, 76);
            // 
            // addNewPrescriptionToolStripMenuItem
            // 
            this.addNewPrescriptionToolStripMenuItem.Name = "addNewPrescriptionToolStripMenuItem";
            this.addNewPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.addNewPrescriptionToolStripMenuItem.Text = "Add New Prescription";
            this.addNewPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.addNewPrescriptionToolStripMenuItem_Click);
            // 
            // updatePrescriptionToolStripMenuItem
            // 
            this.updatePrescriptionToolStripMenuItem.Name = "updatePrescriptionToolStripMenuItem";
            this.updatePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.updatePrescriptionToolStripMenuItem.Text = "Update Prescription";
            this.updatePrescriptionToolStripMenuItem.Click += new System.EventHandler(this.updatePrescriptionToolStripMenuItem_Click);
            // 
            // deletePrescriptionToolStripMenuItem
            // 
            this.deletePrescriptionToolStripMenuItem.Name = "deletePrescriptionToolStripMenuItem";
            this.deletePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.deletePrescriptionToolStripMenuItem.Text = "Delete Prescription";
            this.deletePrescriptionToolStripMenuItem.Click += new System.EventHandler(this.deletePrescriptionToolStripMenuItem_Click);
            // 
            // frmListPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 701);
            this.Controls.Add(this.dgvPrescriptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListPrescription";
            this.Text = "frmListPrescription";
            this.Load += new System.EventHandler(this.frmListPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.cmsPrescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPrescriptions;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsPrescription;
        private System.Windows.Forms.ToolStripMenuItem addNewPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePrescriptionToolStripMenuItem;
    }
}