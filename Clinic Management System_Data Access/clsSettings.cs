using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Clinic_Management_System_Data_Access
{
    public  class clsSettings
    {

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;




    }
}
