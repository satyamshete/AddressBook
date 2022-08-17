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
            Console.WriteLine("Enter details to add a new contact");
            Console.WriteLine("Enter First Name");
            string FName = Console.ReadLine();
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
            AddressBook addressBook = new AddressBook(FName, LName, Address, City, State, ZipCode, PhoneNumber, Email);
            addressBook.display();
        }
    }
}