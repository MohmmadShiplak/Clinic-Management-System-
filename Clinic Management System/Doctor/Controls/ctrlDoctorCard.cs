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
    public partial class ctrlDoctorCard : UserControl
    {

        private int? _DoctorID = null;

        clsDoctor _Doctor;


        public int? DoctorID
        {
            get { return _DoctorID; }
        }

        public ctrlDoctorCard()
        {
            InitializeComponent();
        }

        private void _FillDoctorsInfo()
        {

            _DoctorID = _Doctor.DoctorID.Value;

            ctrlPersonCard1.LoadPersonInfo(_Doctor.PersonID);

            lblDoctorID.Text = _Doctor.DoctorID.ToString();

            lblExperience.Text = _Doctor.Experience.ToString();

            lblSpecification.Text = _Doctor.MajorInfo.MajorName;

            //lblCreatedbyUserID.Text = _Doctor.CreatedUserInfo.Username;

        }
        public void LoadDoctorsInfoByDoctorID(int? DoctorID)
        {

            _DoctorID = DoctorID;

            if (!_DoctorID.HasValue)
            {
                MessageBox.Show("No Patinets With PatientID " + _Doctor.ToString(), "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();

                return;

            }

            _Doctor = clsDoctor.FindByDoctorID(_DoctorID);

            if (_Doctor == null)
            {

           
                MessageBox.Show("No Doctors With DoctorID " + _DoctorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();

                return;
            }
            _FillDoctorsInfo();
        }
        public void LoadDoctorsInfoByPersonID(int ?PersonID)
        {

            _DoctorID = PersonID;

            if (!_DoctorID.HasValue)
            {
                MessageBox.Show("No Patinets With PatientID " + _Doctor.ToString(), "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();

                return;

            }
            _Doctor = clsDoctor.FindByPersonID(PersonID);

            if (_Doctor == null)
            {

                MessageBox.Show("No Doctors With DoctorID " + _DoctorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();

                return;
            }
            _FillDoctorsInfo();
        }
        private void _ResetDefualtValues()
        {

            _DoctorID = null;

            _Doctor = null;
            lblDoctorID.Text = "[????]";
            lblExperience.Text = "[????]";
            lblSpecification.Text = "[????]";
           lblCreatedbyUserID.Text = "[????]";

        }














    }
}
