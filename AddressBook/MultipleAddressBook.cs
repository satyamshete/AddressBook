using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace AddressBook
{
    public class MultipleAddressBook
    {
        public string LName;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public long PhoneNumber;
        public string Email;
        static Dictionary<string, MultipleAddressBook> PhoneBook = new Dictionary<string, MultipleAddressBook>();
        public MultipleAddressBook()
        {
            string LName = null;
            string Address = null;
            string City = null;
            string State = null;
            int ZipCode = 0;
            long PhoneNumber = 0;
            string Email = null;
        }
        public MultipleAddressBook(string lName, string address, string city, string state, int ZipCode, long PhoneNumber, string Email)
        {
            this.LName = lName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            Console.WriteLine("added " + this.PhoneNumber + " To contact");
        }
        public void display()
        {
            Console.WriteLine(" Last Name is " + this.LName + "\n Address is " + this.Address + "\n City is " + this.City + "\n State is " + this.State + "\n ZipCode is " + this.ZipCode + "\n Phone Number is " + this.PhoneNumber + "\n Email is " + this.Email + "\n");
        }
        public void AddNewContact()
        {
            Console.WriteLine("Enter First Name");
            string FName = Console.ReadLine();
            int count = 0;
            if (PhoneBook.Any(x => x.Key == FName))
            {
                Console.WriteLine("Contact is already present");
                count++;
            }
            //foreach (var phone in PhoneBook)
            //{
            //    if (phone.Key == FName)
            //    {
            //        Console.WriteLine("Contact is already present");
            //        count++;


            //    }
            //}
            if (count == 0)
            {
                Console.WriteLine("Enter Last Name");
                string LName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City ");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter ZipCode");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone number");
                long PhoneNumber = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter Email");
                string Email = Console.ReadLine();
                MultipleAddressBook MultipleAddressBook = new MultipleAddressBook(LName, Address, City, State, ZipCode, PhoneNumber, Email);
                PhoneBook.Add(FName, MultipleAddressBook);

            }
        }
        public void DisplayContact()
        {
            if (PhoneBook.Count == 0)
            {
                Console.WriteLine("No Contact Present");

            }

            foreach (var phone in PhoneBook)
            {
                Console.WriteLine("******************************************************************************************************************************");
                Console.WriteLine(" contact details of " + phone.Key);
                phone.Value.display();

            }

        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter first Name");
            string FirstName = Console.ReadLine();
            int track = 0;
            foreach (var phone in PhoneBook)
            {
                if (phone.Key == FirstName)
                {
                    PhoneBook.Remove(phone.Key);
                    Console.WriteLine("Successfully Deleted contact of user " + FirstName);
                    track++;


                }
            }
            if (track == 0)
            {
                Console.WriteLine("contact doesn't exists");

            }
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the first name of user to update the contct");
            string fName = Console.ReadLine();
            int index = 0;
            foreach (var phone in PhoneBook)
            {
                if (phone.Key == fName)
                {
                    index++;
                    Console.WriteLine("Press 1 to update Last Name");
                    Console.WriteLine("Press 2 to update Address");
                    Console.WriteLine("Press 3 to update City");
                    Console.WriteLine("Press 4 to update State");
                    Console.WriteLine("Press 5 to update ZipCode");
                    Console.WriteLine("Press 6 to update Phone Number");
                    Console.WriteLine("Press 7 to update Email");
                    int ip = Convert.ToInt32(Console.ReadLine());
                    switch (ip)
                    {
                        case 1:
                            Console.WriteLine("Enter Last Name");
                            string lName = Console.ReadLine();
                            phone.Value.LName = lName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Address");
                            string address = Console.ReadLine();
                            phone.Value.Address = address;
                            break;
                        case 3:
                            Console.WriteLine("Enter City Name");
                            string city = Console.ReadLine();
                            phone.Value.City = city;
                            break;
                        case 4:
                            Console.WriteLine("Enter State Name");
                            string sName = Console.ReadLine();
                            phone.Value.State = sName;
                            break;
                        case 5:
                            Console.WriteLine("Enter ZIPCODE");
                            int zipCode = Convert.ToInt32(Console.ReadLine());
                            phone.Value.ZipCode = zipCode;
                            break;
                        case 6:
                            Console.WriteLine("Enter PhoneNumber");
                            long phNo = long.Parse(Console.ReadLine());
                            phone.Value.PhoneNumber = phNo;
                            break;
                        case 7:
                            Console.WriteLine("Enter Email address");
                            string email = Console.ReadLine();
                            phone.Value.Email = email;
                            break;
                        default:
                            Console.WriteLine("Enter Proper Selection");
                            break;
                    }

                }
            }
            if (index == 0)
            {
                Console.WriteLine("User with first Name=: " + fName + " not present in contact list");

            }
            else
            {
                Console.WriteLine("User with first Name=: " + fName + " is updated in contact list");

            }
        }
        public void CheckPresentByCityOrStateName()
        {
            Console.WriteLine("Enter City or State Name");
            string City = Console.ReadLine();
            if (PhoneBook.Any(x => x.Value.City == City || x.Value.State == City))
            {
                Console.WriteLine("Contact is present");

            }
            else
            {
                Console.WriteLine("Contact isNot present");

            }

        }
        public void DisplayByCityOrStateName()
        {
            Console.WriteLine("Enter City or State Name");
            string City = Console.ReadLine();
            if (PhoneBook.Any(x => (x.Value.City == City) || (x.Value.State == City)))
            {
                foreach (KeyValuePair<string, MultipleAddressBook> Dict in PhoneBook)
                {

                    if (Dict.Value.State == City || Dict.Value.City == City)
                    {
                        Console.WriteLine("{0} Lives in {1}", Dict.Key, City);
                    }

                }
            }
            else
            {
                Console.WriteLine("No one Lives in {0}", City);
            }

        }
        public void DisplayCountByCityOrStateName()
        {
            Console.WriteLine("Enter City or State Name");
            string City = Console.ReadLine();
            int count = 0;
            if (PhoneBook.Any(x => (x.Value.City == City) || (x.Value.State == City)))
            {
                foreach (KeyValuePair<string, MultipleAddressBook> Dict in PhoneBook)
                {

                    if (Dict.Value.State == City || Dict.Value.City == City)
                    {
                        count++;
                    }

                }
                Console.WriteLine("{0} Lives in {1}", count, City);
            }
            else
            {
                Console.WriteLine("No one Lives in {0}", City);
            }

        }
        public void JSONDesrialization()
        {
            string path = @"C:\Users\satya\OneDrive\Desktop\BridgeLabs\From ASUS\Bridgelabs1\GIT2\AddressBook\AddressBook\ContactBook.json";
            try
            {
                JsonSerializer desrializer = new JsonSerializer();
                using (StreamReader SR = new StreamReader(path))
                {
                    JsonReader jsonReader = new JsonTextReader(SR);
                    PhoneBook = desrializer.Deserialize<Dictionary<string, MultipleAddressBook>>(jsonReader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddContactJSONsrialization()
        {
            string path = @"C:\Users\satya\OneDrive\Desktop\BridgeLabs\From ASUS\Bridgelabs1\GIT2\AddressBook\AddressBook\ContactBook.json";
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamWriter SW = new StreamWriter(fileStream))
                    {
                        JsonSerializer srializer = new JsonSerializer();
                        srializer.Serialize(SW, PhoneBook);
                    }
                }
                Console.WriteLine("contact created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}