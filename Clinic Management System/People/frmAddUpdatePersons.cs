using Clinic_Management_system.Properties;
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
using System.Xml.Linq;

namespace Clinic_Management_system
{
    public partial class frmAddUpdatePersons : Form
    {

        public delegate void DataBackEventHandler(object sender, int ?PersonID);

        public event DataBackEventHandler DataBack;


        public enum enMode { AddNew = 0, UpdateNew = 1 };

        public enMode _Mode = enMode.UpdateNew;

        public enum enGendor { Male = 0, Female = 1 };

        public clsPerson _Person;

        public int _PersonID = -1;


        public frmAddUpdatePersons()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePersons(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.UpdateNew;
        }


        private void ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {

                _Person = new clsPerson();

                return;

            }
       


            //if (rbMale.Checked)
            //    pbPersonImage.Image = Resources.Male_512;
            //else
            //    pbPersonImage.Image = Resources.Female_512;



        
            //txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;
        }

        public void LoadData()
        {



            _Person = clsPerson.Find(_PersonID);


            if (_Person == null)
            {

                MessageBox.Show("No Persons with PersonID " + _PersonID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }




            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;


            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            dtpDateOfBirth.Value = _Person.DateOfBirth;


            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }




        }
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName=txtLastName.Text;

            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Phone = txtPhone.Text;

            if (rbMale.Checked)
                _Person.Gendor = (short)enGendor.Male;
            else
                _Person.Gendor = (short)enGendor.Female;


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {

                lblPersonID.Text = _Person.PersonID.ToString();

                _Mode = enMode.UpdateNew;


                MessageBox.Show("Data Saved Successfully :-)", "Saved"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);


                _Mode = enMode.UpdateNew;

            }
            else
            {

                MessageBox.Show("Data is not Saved  (:-", "Error"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);



            }



        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
           // if(pbPersonImage.ImageLocation == null)
             //   pbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
        //    if (pbPersonImage.ImageLocation == null)
               // pbPersonImage.Image = Resources.Female_512;

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string SelectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(SelectedFilePath);

                llRemoveImage.Visible = true;

            }



        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
            //    pbPersonImage.Image = Resources;
            //else
            //    pbPersonImage.Image = Resources.Female_512;



            llRemoveImage.Visible = true;




        }

        private void frmAddUpdatePersons_Load(object sender, EventArgs e)
        {
            ResetDefualtValues();


            if (_Mode == enMode.UpdateNew)
                LoadData();
        }
    }
}
