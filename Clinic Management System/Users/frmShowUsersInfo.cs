﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_system
{
    public partial class frmShowUsersInfo : Form
    {
        private int? _UserID = null;


        public frmShowUsersInfo(int ?UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmShowUsersInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUsersInfo(_UserID);
        }
    }
}
