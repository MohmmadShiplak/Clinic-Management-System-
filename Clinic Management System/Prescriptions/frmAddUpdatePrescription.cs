
using Clinic_Project_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Management_System_Business;

namespace Clinic_Management_system
{
    public partial class frmAddUpdatePrescription : Form
    {

        private enum enMode { AddNew = 0, UpdateNew = 1 }
        private enMode _Mode;

        private int? _PrescriptionID = null;

        private clsPrescription _Prescription;

        public frmAddUpdatePrescription(int PrescriptionID)
        {
            InitializeComponent();
            _PrescriptionID = PrescriptionID;

            _Mode = enMode.UpdateNew;

        }
        public frmAddUpdatePrescription()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;

        }
        private void FillComboBoxWithMedicationNames()
        {

            DataTable dtMedicationNames = clsMedicationNames.AllOnlyNames();

            foreach (DataRow Row in dtMedicationNames.Rows)
            {
                cbMedicationNames.Items.Add(Row["MedicationName"]);
            }

        }









        private void ResetDefaultValues()
        {

            FillComboBoxWithMedicationNames();

            if (_Mode == enMode.AddNew)
            {

                _Prescription = new clsPrescription();

                  return;

            }



            txtDosage.Text = "[???]";
            txtFrequancy.Text = "[???]";
            txtInstructions.Text = "[???]";
            txtDosage.Text = "[???]";

        }
        public void LoadData()
        {

            _Prescription = clsPrescription.Find(_PrescriptionID);

            if (_Prescription == null)
            {

                MessageBox.Show("No Prescription With PrescriptionID " + _PrescriptionID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();


                return;

            }

            lblPrescriptionsID.Text = _Prescription.PrescriptionID.ToString();
            cbMedicationNames.SelectedIndex = cbMedicationNames.FindString(_Prescription.MedicationNamesInfo.MedicationName);
            txtDosages.Text = _Prescription.Dosage;
            txtFreqeuncy.Text = _Prescription.Frequency;
            dtpStartDates.Value = _Prescription.StartDate;
            dtpEndDates.Value = _Prescription.EndDate;
           txtInstruction.Text = _Prescription.SpecialInstructions;
               ctrlPatientCardWithFilter1.LoadPatientInfoByPatinetID( _Prescription.PatientID );   
        }



        private void btnSave1_Click(object sender, EventArgs e)
        {


            int? MedicationID = clsMedicationNames.Find(cbMedicationNames.Text).MedicationID;


             _Prescription.PatientID = ctrlPatientCardWithFilter1.PatientID;
            _Prescription.MedicationID = MedicationID;
            _Prescription.Dosage = txtDosages.Text;
            _Prescription.Frequency = txtFreqeuncy.Text;
            _Prescription.StartDate = dtpStartDate.Value;
            _Prescription.EndDate = dtpEndDate.Value;
            _Prescription.SpecialInstructions = txtInstruction.Text;

            if (_Prescription.Save())
            {

                lblPrescriptionID.Text = _Prescription.PrescriptionID.ToString();

                MessageBox.Show("Data Saved Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.UpdateNew;

            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddUpdatePrescription_Load(object sender, EventArgs e)
        {

            ResetDefaultValues();

            if (_Mode == enMode.UpdateNew)
                LoadData();

        }
    }
}
