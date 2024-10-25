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
    public partial class frmShowDoctorsInfo : Form
    {
        int? _DoctorID = null;

        public frmShowDoctorsInfo(int? doctorID)
        {
            InitializeComponent();
            _DoctorID = doctorID;
        }

        private void frmShowDoctorsInfo_Load(object sender, EventArgs e)
        {
            ctrlDoctorCard1.LoadDoctorsInfoByDoctorID(_DoctorID);
        }
    }
}
