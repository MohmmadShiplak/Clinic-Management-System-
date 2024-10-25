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
    public partial class frmFindPeople : Form
    {

        private int? _PersonID = null;


        public frmFindPeople(int? personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void frmFindPeople_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }
    }
}
