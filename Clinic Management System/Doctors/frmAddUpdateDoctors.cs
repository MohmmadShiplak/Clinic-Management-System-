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
    public partial class frmAddUpdateDoctors : Form
    {

        public enum enMode { AddNew = 0, Updare = 1 };

        public enMode _Mode;


        private int? _DoctorID = null;

        public clsDoctor _Doctor = null;

        private int? _SelectedDoctorID = null;



        public frmAddUpdateDoctors(int DoctorID)
        {
            InitializeComponent();

            _DoctorID = DoctorID;

            _Mode = enMode.Updare;
        }

        public frmAddUpdateDoctors()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }


        private void _FillComboBoxWithMajorNames()
        {

            DataTable _dtMajorNames = clsMajor.AllOnlyNames();

            foreach (DataRow Row in _dtMajorNames.Rows)
            {
                cbSpecification.Items.Add(Row["MajorName"]);
            }

            if (cbSpecification.Items.Count > 0)
                cbSpecification.SelectedIndex = 0;
        }

        private void ResetDefualtValues()
        {

            _FillComboBoxWithMajorNames();

            if (_Mode == enMode.AddNew)
            {

                _Doctor = new clsDoctor();

               // lblTitle.Text = "Add New Doctors ";

                return;

            }


        }

        public void LoadData()
        {

            _Doctor = clsDoctor.FindByDoctorID(_DoctorID);

            if (_Doctor == null)
            {

                MessageBox.Show("No Doctors With DoctorID " + _DoctorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Doctor.PersonID);
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            cbSpecification.SelectedIndex = cbSpecification.FindString(_Doctor.MajorInfo.MajorName);
            NumericUpDown1.Value = (int)_Doctor.Experience;
            //this will Implement Later 
            //   lblCreatedByUserID.Text = clsGlobal.CurrentUser.Username;
        }

        private void frmAddUpdateDoctors_Load(object sender, EventArgs e)
        {
            ResetDefualtValues();

            if (_Mode == enMode.Updare)
                LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Doctor.DoctorID = _SelectedDoctorID;
            _Doctor.Experience = (byte)NumericUpDown1.Value;
            _Doctor.MajorID = clsMajor.GetMajorID(cbSpecification.Text);
            _Doctor.PersonID = ctrlPersonCardWithFilter1.PersonID;
            //  _Doctor.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Doctor.Save())
            {

                lblDoctorID.Text = _Doctor.DoctorID.ToString();


                MessageBox.Show("Data Saved Successfully :-)", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Updare;



            }
            else
            {

                MessageBox.Show("Data Failed to Save (:-", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {
            if (!e.PersonID.HasValue)
            {

                btnSave.Enabled = false;

                return;

            }


            if (_Mode == enMode.AddNew && ctrlPersonCardWithFilter1.PersonInfo.IsDoctor())
            {

                MessageBox.Show("This Person Already Selected as a Doctor Please Choose Onther One", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;


                return;
            }


            btnSave.Enabled = true;

            _SelectedDoctorID = e?.PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
