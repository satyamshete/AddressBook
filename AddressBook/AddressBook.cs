using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        string FName;
        string LName;
        string Address;
        string City;
        string State;
        int ZipCode;
        long PhoneNumber;
        string Email;
        public AddressBook(string fName, string lName, string address, string city, string state, int ZipCode, long PhoneNumber, string Email)
        {

            this.FName = fName;
            this.LName = lName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;

        }
        public void display()
        {
            Console.WriteLine("First Name is " + this.FName);
            Console.WriteLine("Last Name is " + this.LName);
            Console.WriteLine("Address is " + this.Address);
            Console.WriteLine("City is " + this.City);
            Console.WriteLine("State is " + this.State);
            Console.WriteLine("ZipCode is " + this.ZipCode);
            Console.WriteLine("Phone Number is " + this.PhoneNumber);
            Console.WriteLine("Email is " + this.Email);
            Console.WriteLine("******************************************************************************************************************************");


        }
        public void edit()
        {
            Console.WriteLine();
            Console.WriteLine("Press 0 to update First Name");
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
                case 0:
                    Console.WriteLine("Enter first Name");
                    string fName = Console.ReadLine();
                    this.FName = fName;
                    break;
                case 1:
                    Console.WriteLine("Enter Last Name");
                    string lName = Console.ReadLine();
                    this.LName = lName;
                    break;
                case 2:
                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    this.Address = address;
                    break;
                case 3:
                    Console.WriteLine("Enter City Name");
                    string city = Console.ReadLine();
                    this.City = city;
                    break;
                case 4:
                    Console.WriteLine("Enter State Name");
                    string sName = Console.ReadLine();
                    this.State = sName;
                    break;
                case 5:
                    Console.WriteLine("Enter ZIPCODE");
                    int zipCode = Convert.ToInt32(Console.ReadLine());
                    this.ZipCode = zipCode;
                    break;
                case 6:
                    Console.WriteLine("Enter PhoneNumber");
                    int phNo = Convert.ToInt32(Console.ReadLine());
                    this.PhoneNumber = phNo;
                    break;
                case 7:
                    Console.WriteLine("Enter Email address");
                    string email = Console.ReadLine();
                    this.Email = email;
                    break;
            }
            Console.WriteLine("Contact updated Successfully");
            Console.WriteLine();
            display();
            Console.WriteLine();
        }
        internal void Delete()
        {
            this.FName = null;
            this.LName = null;
            this.Address = null;
            this.City = null;
            this.State = null;
            this.ZipCode = 0;
            this.PhoneNumber = 0;
            this.Email = null;
            Console.WriteLine("Contact Deleted");
        }
    }
}

