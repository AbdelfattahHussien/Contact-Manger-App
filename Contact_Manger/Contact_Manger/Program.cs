namespace Contact_M
{
    internal class Program
    {
        static Contacts contact = new Contacts();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("Select one Option :\n1-Add New User\n2-Edit User\n3-Search User\n4-Print All User\n5-Remove User");
                string input = Console.ReadLine();
                int chose;
                if (int.TryParse(input, out chose))
                {
                    if (chose == 1)
                    {

                        Console.WriteLine("==================Add User=================");
                        // Add  User
                        contact.AddUser(AddUserInformation());

                    }
                    else if (chose == 2)
                    {
                        //Edit User
                        Console.WriteLine("==================Edit User=================");
                        Console.Write("Enter Id:");
                        var id = Console.ReadLine();
                        Console.WriteLine("Enter New User Information:");
                        //Add New User 
                        contact.EditUser(int.Parse(id),AddUserInformation());
                       // Console.WriteLine("New User Information:");                       

                    }
                    else if (chose == 3)
                    {
                        //Search User
                        Console.WriteLine("==================Search User=================");
                        Console.Write("Enter id :");
                        var id = Console.ReadLine();
                        var user = contact.Search(id);
                        if (user != null)
                        {
                            user.Show();
                        }
                        else
                        {
                            Console.WriteLine("No user found with the provided information.");
                        }

                    }
                    else if (chose == 4)
                    {
                        //Print All User
                        Console.WriteLine("==================Print All User=================");
                        contact.PrintAllUsers();

                    }
                    else if (chose == 5)
                    {
                        //Remove User
                        Console.WriteLine("==================Remove User=================");
                        Console.Write("Enter Id:");
                        var id = Console.ReadLine();
                        contact.DeleteUser(int.Parse(id));

                    }

                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }

            }
        }
        static User AddUserInformation()
        {
            Console.Write("Enter Id:");
            var id = Console.ReadLine();
            Console.Write("Enter First Name:");
            var firstname = Console.ReadLine();
            Console.Write("Enter Last Name:");
            var lastname = Console.ReadLine();
            Console.Write("Enter Gender:");
            var gender = Console.ReadLine();
            Console.Write("Enter City:");
            var city = Console.ReadLine();
           
            var _user = new User(int.Parse(id), firstname, lastname, gender, city, DateTime.Now);
            
            Console.WriteLine("Enter Emails Information:");
            string addEmail = "";

            do
            {
                Console.Write("Enter your email:");
                var email = Console.ReadLine();
                Console.Write("Enter Type:");
                var type = Console.ReadLine();
                Console.Write("Enter dyscryptin:");
                var dyscryption = Console.ReadLine();
                var _email = new Email(email, type, dyscryption);
                _user.Add("email",_email);
                Console.WriteLine("Do you want to add another email ?\n yes or no ?");

                addEmail = Console.ReadLine();
                if (addEmail.ToLower() == "no")
                {
                    addEmail = "no";
                }

            } while (addEmail == "yes");


            Console.WriteLine("Enter Addresses Information:");
            string addaddress = "";

            do
            {
                Console.Write("Enter your Place:");
                var address = Console.ReadLine();
                Console.Write("Enter Type:");
                var _type = Console.ReadLine();
                Console.Write("Enter Descryption:");
                var _dyscryption = Console.ReadLine();
                var _address = new Address(address, _type, _dyscryption);
                _user.Add("address",_address);
                Console.Write("Do you want to add another address ?\n yes or no ?");

                addaddress = Console.ReadLine();
                if (addaddress.ToLower() == "no")
                {
                    addaddress = "no";
                }

            } while (addaddress == "yes");
            Console.WriteLine("Enter Phone Information:");
            string addphone = "";

            do
            {
                Console.Write("Enter your Phone:");
                var phone = Console.ReadLine();
                Console.Write("Enter Type:");
                var type = Console.ReadLine();
                Console.Write("Enter Descryption:");
                var dyscryption = Console.ReadLine();
                var _phone = new Phone(phone, type, dyscryption);
                _user.Add("phone",_phone);
                Console.Write("Do you want to add another address ?\n yes or no ?");

                addphone = Console.ReadLine();
                if (addphone.ToLower() == "no")
                {
                    addphone = "no";
                }

            } while (addphone == "yes");

            return _user;
        }
    }
}
