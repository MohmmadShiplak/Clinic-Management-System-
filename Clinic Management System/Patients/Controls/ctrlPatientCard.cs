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

namespace Clinic_Management_system
{
    public partial class ctrlPatientCard : UserControl
    {

        private int? _PatientID = null;

        public int? PatientID
        {
            get { return _PatientID; }
        }

        private int? _PersonID = null;


        public int? PersonID
        {
            get { return _PersonID; }
        }




        private clsPatient _Patient;


        public clsPatient SelectedPatientInfo
        {
            get { return _Patient; }
        }



        private clsAppointments _Appointemnt;

        public clsAppointments SelectedAppointmentInfo
        {
            get { return _Appointemnt; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        clsPerson _Person;

        public void FillPatientsInfo()
        {

            _PatientID = _Patient.PatientID.Value;


            ctrlPersonCard1.LoadPersonInfo(_Patient.PersonID);
            lblPatientID.Text = _Patient.PatientID.ToString();
          lblSickName.Text = _Patient.illnessesInfo.illnessName;
           lblNotes.Text = _Patient.Notes;
            lblCreationDate.Text = clsFormat.DateToShort(_Patient.CreationDate.Value);
        }
        public void LoadPatientInfoByPersonID(int? PersonID)
        {

            _Patient = clsPatient.FindbyPersonID(PersonID);

            if (_Patient == null)
            {

                MessageBox.Show("No Patinets With PatientID " + _PatientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetDefualtValues();

                return;

            }
            FillPatientsInfo();
        }
        public void LoadPatientInfoByPatientID(int? PatientID)
        {

            _PatientID = PatientID;

            if (!_PatientID.HasValue)
            {
                MessageBox.Show("No Patinets With PatientID " + _PatientID.ToString(), "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetDefualtValues();

                return;

            }
            _Patient = clsPatient.FindbyPatientID(_PatientID);

            if (_Patient == null)
            {

                MessageBox.Show("No Patinets With PatientID " + _PatientID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetDefualtValues();

                return;

            }
            FillPatientsInfo();
        }
        private void ResetDefualtValues()
        {

            _Patient = null;
            _PatientID = null;


            lblPatientID.Text = "[???]";
           lblSickName.Text = "[???]";
            lblNotes.Text = "[???]";
            lblCreationDate.Text = "[???]";
        }

















        public ctrlPatientCard()
        {
            InitializeComponent();
        }
    }
}
