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
    public partial class ctrlDoctorCardWithFilter : UserControl
    {
        public class clsDoctorsSelectedEventArgs : EventArgs
        {

            public int? DoctorID { get; set; }

            public clsDoctorsSelectedEventArgs(int? DoctorID)
            {
                this.DoctorID = DoctorID;
            }
        }
        public event EventHandler<clsDoctorsSelectedEventArgs> OneDoctorSelected;

        public void RaiseOneDoctorSelected(int? DoctorID)
        {
            RaiseOneDoctorSelected(new clsDoctorsSelectedEventArgs(DoctorID));
        }
        protected void RaiseOneDoctorSelected(clsDoctorsSelectedEventArgs e)
        {
            OneDoctorSelected?.Invoke(this, e);
        }

        public clsDoctor _Doctor;

        //expose it ouside the control 
        public int? DoctorID
        {
            get { return ctrlDoctorCard1?.DoctorID; }
        }
        //display and hide filter based on value true or false 
        public bool FilterEnabled
        {
            get => ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
        }


        public void LoadDoctorsInfoByDoctorID(int? DoctorID)
        {

            ctrlFilter1.TextSearch = DoctorID?.ToString();
            ctrlDoctorCard1.LoadDoctorsInfoByDoctorID(DoctorID);

            if (OneDoctorSelected != null)
                RaiseOneDoctorSelected(ctrlDoctorCard1?.DoctorID);


        }

        public void LoadDoctorsInfo(int ?DoctorID )
        {
            ctrlFilter1.TextSearch = DoctorID?.ToString();
            ctrlDoctorCard1.LoadDoctorsInfoByDoctorID(DoctorID);

            if (OneDoctorSelected != null)
                RaiseOneDoctorSelected(ctrlDoctorCard1?.DoctorID);
        }

        public void LoadDoctorsInfoByPersonID(int ?PersonID)
        {

            ctrlFilter1.TextSearch = PersonID?.ToString();
            ctrlDoctorCard1.LoadDoctorsInfoByPersonID(PersonID);

            if (OneDoctorSelected != null)
                RaiseOneDoctorSelected(ctrlDoctorCard1.DoctorID);


        }
        public ctrlDoctorCardWithFilter()
        {
            InitializeComponent();

            //add doctorID in combobox 
            ctrlFilter1.ItemsInComboBox(new[] { ("Doctor ID", true) });


        }

        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {
            switch (e?.FieldName)
            {

                case "Doctor ID":
              LoadDoctorsInfoByDoctorID(e?.Value);
                    break;
            }
        }
    }
}
