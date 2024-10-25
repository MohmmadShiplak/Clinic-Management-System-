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
    public partial class frmShowPatientInfo : Form
    {

        private int ?_PatientID = null;
        public frmShowPatientInfo(int? patientID)

        {
            InitializeComponent();
            _PatientID = patientID;
        }

        private void frmShowPatientInfo_Load(object sender, EventArgs e)
        {
            ctrlPatientCard1.LoadPatientInfoByPatientID(_PatientID);
        }
    }
}
