namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!!!!");
            ////UC1 Create Contact
            AddressBook addressBook = new AddressBook("Satyam", "Shete", "Near xyz", "Pune", "Maharashtra", 415896, 2004155615, "sat@gamil.com");
            addressBook.display();
        }
    }
}