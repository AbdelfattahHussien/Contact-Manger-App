using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_M
{
    internal class Phone
    {
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public string Descryption { get; set; }

        public Phone(string phonenumber, string type, string descryption)
        {
            PhoneNumber = phonenumber;
            Type = type;
            Descryption = descryption;

        }
        public void SetPlace(string phonenumber)
        {
            PhoneNumber = phonenumber;

        }
        public void SetType(string type)
        {
            Type = type;
        }
        public void SetDescryption(string dyscryption)
        {
            Descryption = dyscryption;
        }

        public string GetPhone()
        {
            return $"{PhoneNumber} ({Type}) -{Descryption}";
        }




    }
}
