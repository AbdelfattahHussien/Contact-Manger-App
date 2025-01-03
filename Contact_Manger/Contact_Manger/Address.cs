using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_M
{
    internal class Address
    {
        public string Place       { get; set; }
        public string Type        { get; set; }
        public string Descryption { get; set; }

        public Address(string place ,string type,string descryption)
        {
            Place = place;    
            Type = type;
            Descryption = descryption;
        
        }
        public void SetPlace(string place)
        {
            Place=place;    
            
        }
        public void SetType(string type)
        {
            Type = type;
        }
        public void SetDescryption(string dyscryption)
        {
            Descryption = dyscryption;
        }

        public string GetAddress()
        {
            return $"{Place},{Type},{Descryption}";
        }




    }
}
