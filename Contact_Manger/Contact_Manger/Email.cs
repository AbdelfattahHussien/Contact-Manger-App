using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_M
{
    internal class Email
    {
        public string EmailAddress { get; set; }
        public string Type { get; set; }
        public string Descryption { get; set; }

        public Email(string emailaddress, string type, string descryption)
        {
            EmailAddress = emailaddress;
            Type = type;
            Descryption = descryption;

        }
        public void SetPlace(string place)
        {
            EmailAddress = place;

        }
        public void SetType(string type)
        {
            Type = type;
        }
        public void SetDescryption(string dyscryption)
        {
            Descryption = dyscryption;
        }

        public string GetEmail()
        {
            return $"{EmailAddress} ({Type}) -{Descryption}";
        }






    }
}
