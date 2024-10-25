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
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        #region Declare Event
        public class PersonSelectedEventArgs : EventArgs
        {
            public int? PersonID { get; }

            public PersonSelectedEventArgs(int? personID)
            {
                PersonID = personID;
            }
        }

        public event EventHandler<PersonSelectedEventArgs> OnPersonSelected;

        public void RaiseOnPersonSelected(int? personID)
        {
            RaiseOnPersonSelected(new PersonSelectedEventArgs(personID));
        }

        protected  virtual void RaiseOnPersonSelected(PersonSelectedEventArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }
        #endregion

        public int? PersonID => ctrlPersonCard1.PersonID;
        public clsPerson SelectedPersonInfo => ctrlPersonCard1.SelectedPersonInfo;

        public bool FilterEnabled
        {
            get =>ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
        }




        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();

            ctrlFilter1.ItemsInComboBox(new[] { ("Person ID", true) });
        }

        public void LoadPersonInfo(int? personID)
        {
           ctrlFilter1.TextSearch = personID.ToString();
            ctrlPersonCard1.LoadPersonInfo(personID);

            if (OnPersonSelected != null)
                RaiseOnPersonSelected(ctrlPersonCard1?.PersonID);
        }


        public void FilterFocus() => ctrlFilter1.FilterFocus();

    

        private void ucPersonCard1_Load(object sender, EventArgs e)
        {
            ctrlFilter1.FilterFocus();
        }







        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {

            switch (e?.FieldName)
            {
                case "Person ID":
                    LoadPersonInfo(e?.Value);
                    break;
            }




        }

        private void ctrlFilter1_OnAddClick(object sender, EventArgs e)
        {
            //frmAddEditPerson addPerson = new frmAddEditPerson();
            //addPerson.PersonIDBack += LoadPersonInfo;
            //addPerson.ShowDialog();
        }
    }
}
