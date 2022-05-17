using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberAnalysis_Tuples
{
    using System;



    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            bool newYork = phoneNumber.Substring(0, 3) == "212" ? true : false;
            //bool fake = phoneNumber.Substring(4,3) == "555" ? true : false;
            bool Fake(string value)
            {
                bool fake = phoneNumber.Substring(4, 3) == "555" ? true : false;
                return fake;
            }
            string locnumber = phoneNumber.Substring(8);
            return (newYork, Fake(phoneNumber), locnumber);
            throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            return phoneNumberInfo.IsFake;
            throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
        }


    }

}
