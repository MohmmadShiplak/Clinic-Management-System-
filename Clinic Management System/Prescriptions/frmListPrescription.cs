
using Clinic_Management_System_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Management_system;
namespace Clinic_Management_system
{
    public partial class frmListPrescription : Form
    {

        private DataTable _dtAllPrescription;

        public frmListPrescription()
        { 
            InitializeComponent();
        }

        private void frmListPrescription_Load(object sender, EventArgs e)
        {
            _dtAllPrescription = clsPrescription.GetAllPrescriptions();
            dgvPrescriptions.DataSource = _dtAllPrescription;

            if (dgvPrescriptions.Columns.Count > 0)
            {



                dgvPrescriptions.Columns[0].HeaderText = "PrescriptionID";
                dgvPrescriptions.Columns[0].Width = 140;

                dgvPrescriptions.Columns[1].HeaderText = "Patient Name";
                dgvPrescriptions.Columns[1].Width = 150;

                dgvPrescriptions.Columns[2].HeaderText = "Medication Name";
                dgvPrescriptions.Columns[2].Width = 130;

                dgvPrescriptions.Columns[3].HeaderText = "Dosage";
                dgvPrescriptions.Columns[3].Width = 130;

                //dgvPatients.Columns[4].HeaderText = "Frequancy";
                dgvPrescriptions.Columns[4].Width = 120;


            }

        }

        private void addNewPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmAddUpdatePrescription();
            frm1.ShowDialog();
            frmListPrescription_Load(null, null);

        }

        private void updatePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int PrescriptionID = (int)dgvPrescriptions.CurrentRow.Cells[0].Value;

            Form frm1 = new frmAddUpdatePrescription(PrescriptionID);
            frm1.ShowDialog();
            frmListPrescription_Load(null, null);


        }

        private void deletePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int PrescriptionID = (int)dgvPrescriptions.CurrentRow.Cells[0].Value;


            if (clsPrescription.DeletePrescription(PrescriptionID))
            {

                MessageBox.Show("Prescription Deleted Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListPrescription_Load(null, null);
                return;

            }
            else
            {
                MessageBox.Show("Prescription is not Deleted due data to Connect it ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
