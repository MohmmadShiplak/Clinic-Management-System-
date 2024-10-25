using Clinic_Management_system;
using Clinic_Management_System_Business;
using Clinic_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Project_Business
{
    public partial class frmMain : Form
    {
        frmLogin frmLogin;  

        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            this.frmLogin = frm;   
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmDashboard();
            frm1.ShowDialog();

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmListAppointment();
            frm1.ShowDialog();


        }

        private void btnPatients_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmListPatients();
            frm1.ShowDialog();

        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmListDoctors();
            frm1.ShowDialog();

        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmListPrescription();
            frm1.ShowDialog();

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {

            Form frm1 = new frmListPayments();
            frm1.ShowDialog();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm1 = new frmSettings();
            frm1.ShowDialog();
        }

        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            frmListMedicalRecords frm1=new frmListMedicalRecords();
            frm1.ShowDialog();
        }
    }
}
