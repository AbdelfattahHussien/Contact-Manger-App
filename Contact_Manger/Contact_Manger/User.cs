using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_M
{
    internal class User
    {
        //attributes
        public int Id          { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender      { get; set; }
        public string City        { get; set; }
        public DateTime AddedDate { get; set; }

        //composed attributes
        public List<Email>   emails    { get; set; }
        public List<Phone>   phones    { get; set; }
        public List<Address> addresses { get; set; }


        // Constructor
        public User(int id, string firstname, string lastname, string gender, string city, DateTime addedDate)
        {
            Id        = id;
            FirstName = firstname;
            LastName  = lastname;
            Gender    = gender;
            City      = city;
            AddedDate = addedDate;
            addresses = new List<Address>();
            phones = new List<Phone>();
            emails = new List<Email>();

        }
        //Add Email,Address and Phone ---> Object
        public void Add(string type,object value)
        {
            if(type.ToLower() == "address")
            {
                addresses.Add(value as Address);

            }
            else if(type.ToLower() == "email")
            {
                emails.Add(value as Email);
            }
            else if(type.ToLower() == "phone")
            {
                phones.Add(value as Phone);
            }
            else
            {
                Console.WriteLine("Invalid Type");
            }
        }
        public void Edit(string type, object oldvalue, object newvalue)
        {
            if (type.ToLower() == "address")
            {
                if (addresses.Contains(oldvalue as Address))
                {
                    addresses[addresses.IndexOf(oldvalue as Address)] = newvalue as Address;
                }
                else
                {
                    Console.WriteLine("Not Found Address");

                }

            }
            else if (type.ToLower() == "email")
            {
                if (emails.Contains(oldvalue as Email))
                {
                    emails[emails.IndexOf(oldvalue as Email)] = newvalue as Email;
                }
                else
                {
                    Console.WriteLine("Not Found Email");

                }
            }
            else if (type.ToLower() == "phone")
            {
                if (phones.Contains(oldvalue as Phone))
                {
                    phones[phones.IndexOf(oldvalue as Phone)] = newvalue as Phone;
                }
                else
                {
                    Console.WriteLine("Not Found Phone");

                }
            }
            else
            {
                Console.WriteLine("Invalid Type");
            }
        }
        public void Remove(string type,object value)
        {
            if (type.ToLower() == "address")
            {
                if(addresses.Contains(value as Address))
                {
                    addresses.Remove(value as Address);
                }
                else
                {
                    Console.WriteLine("Not Found Address");
                }
            }
            else if(type.ToLower() == "email")
            {
                if (emails.Contains(value as Email))
                {
                    emails.Remove(value as Email);
                }
                else
                {
                    Console.WriteLine("Not Found Email");
                }

            }
            else if(type.ToLower() == "phone")
            {
                if (phones.Contains(value as Phone))
                {
                    phones.Remove(value as Phone);
                }
                else
                {
                    Console.WriteLine("Not Found Phone");
                }

            }
            else
            {
                Console.WriteLine("Invalid Type");
            }
        }
        public bool MatchesSearchTerm(string searchTerm)
        {
            return addresses.Any(x => x.ToString().Contains(searchTerm)) ||
           emails.Any(x => x.ToString().Contains(searchTerm)) ||
           phones.Any(x => x.ToString().Contains(searchTerm));
        }
        public void Show()
        {
            Console.WriteLine("======================User Information=================");
            Console.WriteLine($"Id         = {Id}");
            Console.WriteLine($"First Name : {FirstName}");
            Console.WriteLine($"Last Name  : {LastName}");
            Console.WriteLine($"Gender     : {Gender}");
            Console.WriteLine($"City       : {City}");
            Console.WriteLine($"Added Date :{AddedDate}");
            Console.WriteLine("============Addresses============");
            foreach (Address address in addresses)
            {

                Console.WriteLine($"{address.GetAddress()}");
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("============Emails============");
            foreach (Email email in emails)
            {
                Console.WriteLine($"{email.GetEmail()}");
                Console.WriteLine("-------------------------");

            }
            Console.WriteLine("============Phones============");
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"{phone.GetPhone()}");
                Console.WriteLine("-------------------------");

            }


        }





    }
}
