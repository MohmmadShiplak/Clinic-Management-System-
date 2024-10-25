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
    public partial class ctrlPatientCardWithFilter : UserControl
    {


        public clsPatient SelectedPatinetInfo
        {
            get { return ctrlPatientCard1.SelectedPatientInfo; }
        }
        public class clsPatientSelectedEventArgs : EventArgs
        {

            public int? PatientID { get; set; }

            public clsPatientSelectedEventArgs(int? PatientID)
            {
                this.PatientID = PatientID;
            }
        }
        public event EventHandler<clsPatientSelectedEventArgs> OnePatientSelected;

        public void RaiseOnePatientSelected(int? PatientID)
        {
            RaiseOnePatientSelected(new clsPatientSelectedEventArgs(PatientID));
        }
        protected void RaiseOnePatientSelected(clsPatientSelectedEventArgs e)
        {
            OnePatientSelected?.Invoke(this, e);
        }
        public int? PatientID
        {
            get { return ctrlPatientCard1?.PatientID; }
        }


        public void LoadPatientInfoByPatinetID(int? PatientID)
        {

            ctrlFilter1.TextSearch = PatientID?.ToString();

            ctrlPatientCard1.LoadPatientInfoByPatientID(PatientID);

            if (OnePatientSelected != null)
                RaiseOnePatientSelected(ctrlPatientCard1?.PatientID);

        }
        public bool FilterEnabled
        {
            get => ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
        }

        public void LoadPatinetsInfo(int? PatientID)
        {
            ctrlFilter1.TextSearch = PatientID.ToString();
            ctrlPatientCard1.LoadPatientInfoByPatientID(PatientID);

            if (OnePatientSelected != null)
                RaiseOnePatientSelected(ctrlPatientCard1?.PatientID);
        }

        public ctrlPatientCardWithFilter()
        {
            InitializeComponent();

            ctrlFilter1.ItemsInComboBox(new[] { ("Patient ID", true) });

        }

        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {
            switch (e?.FieldName)
            {

                case "Patient ID":
                  LoadPatinetsInfo(e?.Value);
                    break;
            }


        }
    }
}
