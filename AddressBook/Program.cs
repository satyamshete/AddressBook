namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!!!!");
            ////UC1 Create Contact
            //AddressBook addressBook = new AddressBook("Satyam", "Shete", "Near xyz", "Pune", "Maharashtra", 415896, 2004155615, "sat@gamil.com");
            //addressBook.display();

            ////UC2 Add new Contact
            //Console.WriteLine("Enter details to add a new contact");
            //Console.WriteLine("Enter First Name");
            //string FName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //string LName = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //string Address = Console.ReadLine();
            //Console.WriteLine("Enter City ");
            //string City = Console.ReadLine();
            //Console.WriteLine("Enter State");
            //string State = Console.ReadLine();
            //Console.WriteLine("Enter ZipCode");
            //int ZipCode = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Phone number");
            //long PhoneNumber = long.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Email");
            //string Email = Console.ReadLine();
            //AddressBook addressBook = new AddressBook(FName, LName, Address, City, State, ZipCode, PhoneNumber, Email);
            //addressBook.display();

            //////UC3 to edit contact
            //Console.WriteLine();
            //Console.WriteLine("Press 1 for edit");
            //Console.WriteLine("Press 2 for delete");
            //int input = int.Parse(Console.ReadLine());

            //switch (input)
            //{
            //    case 1:
            //        ////////to edit
            //        Console.WriteLine();
            //        addressBook.edit();
            //        Console.WriteLine();
            //        break;
            //    case 2:
            //        ///// to delete
            //        addressBook.Delete();
            //        break;
            //    default:
            //        Console.WriteLine("Wrong selection");
            //        break;


            /////For Multiple Contacts
          //  Dictionary<string, MultipleAddressBook> PhoneBook = new Dictionary<string, MultipleAddressBook>();
            bool ToStop = true;
            while (ToStop)
            {
                Console.WriteLine();
                Console.WriteLine("press 1 to add to contact");
                Console.WriteLine("press 2 to see the contact list");
                Console.WriteLine("press 3 to delete the contact from list");
                Console.WriteLine("press 4 to update the contact from list");
                Console.WriteLine("press 5 to check if person is present by city or state name");
                Console.WriteLine("press 6 to Stop");
                int input = Convert.ToInt32(Console.ReadLine());
                MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
                switch (input)
                {
                    case 1:
                        multipleAddressBook.AddNewContact();
                        break;

                    case 2:
                        multipleAddressBook.DisplayContact();
                        break;
                    case 3:
                        multipleAddressBook.DeleteContact();
                        break;

                    case 4:
                        multipleAddressBook.EditContact();
                        break;
                    case 5:
                        {
                            multipleAddressBook.CheckPresentByCityOrStateName();
                        }
                        break;
                    case 6:
                        {
                            ToStop = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Make Proper Selection");
                        break;
                }

            }
        }
    }
}