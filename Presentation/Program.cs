
using System.Runtime.InteropServices;
using UppgiftKontaktlista.Models;

var registerContact = new RegisterConcact();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Create contact");
    Console.WriteLine("2. View all contact");
    Console.WriteLine("3. Exit");

    var input = Console.ReadLine();


    switch (input)
    {
        case "1":
            registerContact.CreateContact();
            break;


        case "2":
            registerContact.ViewAllContacts();
            break;

            case "3":
            Console.WriteLine("Existing contact list");
            return;

            default:
            Console.WriteLine("Invalid option, please select on of the avaible options.");
            break;

    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}