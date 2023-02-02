using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexx
{
   public class pincode
    {
        public static string PINCODE = "^[1-9][0-9]{5}$";
        public static string PINCODE_ = "^[a-c]@[a-z].[com]$";
   

        public bool checkPincode(string pincodee)
        {
            return Regex.IsMatch(pincodee, PINCODE);
         
        }
    }
}
