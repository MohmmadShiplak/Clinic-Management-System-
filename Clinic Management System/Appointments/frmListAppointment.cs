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

namespace Clinic_Management_system
{
    public partial class frmListAppointment : Form
    {
        private DataTable _dtAppointments;


        public frmListAppointment()
        {
            InitializeComponent();
        }

        private void frmListAppointment_Load(object sender, EventArgs e)
        {

            _dtAppointments = clsAppointments.GetAllApoointments();
            dgvAppointments.DataSource = _dtAppointments;


            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[1].HeaderText = "Full Name";
                dgvAppointments.Columns[1].Width = 220;

                dgvAppointments.Columns[2].HeaderText = "Sick Name";
                dgvAppointments.Columns[2].Width = 129;

                dgvAppointments.Columns[3].HeaderText = "Time";
                dgvAppointments.Columns[3].Width = 129;

            }

        }

        private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;


            frmAddUpdateAppointment frm1 = new frmAddUpdateAppointment(AppointmentID);
            frmListAppointment_Load(null, null);
            frm1.ShowDialog();

        }

        private void deleteAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;


            if (clsAppointments.DeleteAppointment(AppointmentID))
            {

                MessageBox.Show("Appointment Deleted Sucessfully :-)", "Sucess"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                 frmListAppointment_Load(null, null);
            }
            else
            {

                MessageBox.Show("Appointment is not Deleted )-:", "Failed "
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


         frmAddUpdateAppointment frm1 = new frmAddUpdateAppointment();
         frm1.ShowDialog();
         frmListAppointment_Load(null, null);


        }
    }
}
