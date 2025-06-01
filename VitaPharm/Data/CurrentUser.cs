using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaPharm.Data
{
    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int EmployeeID { get; set; }
        public static string EmployeeName { get; set; }
    }
}
