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
using System.IO;

namespace Clinic_Management_system
{
    public partial class ctrlPersonCard : UserControl
    {

      public   int ? _PersonID =null;

        public  clsPerson _Person;

        public int ?PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }


        public ctrlPersonCard()
        {
            InitializeComponent();
        }
 


   
        public void FillPersonsInfo()
        {

            //this line of code will stotre value of Control ctrlPersonCardwithFilter in databasw
            
            _PersonID = _Person.PersonID.Value;

            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName().ToString();
            lblAddress.Text = _Person.Address.ToString();
            lblEmail.Text = _Person.Email.ToString();
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblGender.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            lblPhone.Text = _Person.Phone.ToString();
            lblAge.Text = (DateTime.Now.Year - _Person.DateOfBirth.Year).ToString();
            LoadPersonImage();

        }
        public void LoadPersonInfo(int ?PersonID)
        {

            _PersonID = PersonID;

   



            if (!_PersonID.HasValue)
            {
                MessageBox.Show("There is No Persons with PersonID " + _PersonID.ToString(), "Error"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();

                return;
            }


            _Person = clsPerson.Find(_PersonID);


            if (_Person == null)
            {

                MessageBox.Show("There is No Persons with PersonID " + _PersonID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();

                return;
            }

            FillPersonsInfo();
        }
        private void LoadPersonImage()
        {

            //if (_Person.Gendor == 0)
            //    pbPersonImage.Image = Resources.Male_512;
            //else
            //    pbPersonImage.Image = Resources.Female_512; ;


            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not Find this Image =" + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        public void _ResetDefualtValues()
        {

            _PersonID = null;
            _Person = null;

            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            //  .Image = Resources.gender_male;
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblAge.Text = "[????]";
            lblAddress.Text = "[????]";

        }








        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
