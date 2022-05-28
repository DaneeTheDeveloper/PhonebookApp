// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to your Console Phonebook App");
Console.WriteLine("Select operation");
Console.WriteLine("1) Add contact");
Console.WriteLine("2) Display contact by number");
Console.WriteLine("3) View all contacts");
Console.WriteLine("4) Search for contacts for a given name");
Console.WriteLine("Press 'x' to exit.");
Console.WriteLine();

var userInput = Console.ReadLine();

var phoneBook = new Phonebook();

while(true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Contact name:");
            var name = Console.ReadLine();
            Console.WriteLine("Contact number:");
            var number = Console.ReadLine();

            var newContact = new Contact(name, number);
            phoneBook.AddContact(newContact);
            break;
        case "2":
            Console.WriteLine("Search contact number...");
            var searchNumber = Console.ReadLine();
            phoneBook.DisplayContact(searchNumber);
            break;
        case "3":
            phoneBook.DisplayAllContact();
            break;
        case "4":
            Console.WriteLine("Search contact name...");
            var searchName = Console.ReadLine();
            phoneBook.DisplayMatchingContacts(searchName);
            break;
        case "x":
            return;
        default:
            Console.WriteLine("Select valid operation");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Select operation");
    Console.WriteLine("1) Add contact");
    Console.WriteLine("2) Display contact by number");
    Console.WriteLine("3) View all contacts");
    Console.WriteLine("4) Search for contacts for a given name");
    Console.WriteLine("Press 'x' to exit.");
    Console.WriteLine();

    userInput = Console.ReadLine();
}
