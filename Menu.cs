using System.ComponentModel.DataAnnotations;

namespace CS_EventManager;
class Menu
{
    public static int MenuMain()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("Welcome to the Duy Xuyen Runners!");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Register for an event");
        Console.WriteLine("2. Add new events");
        Console.WriteLine("3. Remove registered in list events");
        Console.WriteLine("4. Search registered events");
        Console.WriteLine("5. View all registered events");
        Console.WriteLine("------------------END------------------");
        int option;
        while(!int.TryParse(Console.ReadLine(), out option) || option > 5 || option < 1)
        {
            Console.WriteLine("Invalid option: " + option + "Please try again.");
        }
        return option;
    }
    public static (string name, string email, string eventName, int numberOfAttendees) MenuRegistrations()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("Register for an event!");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Enter name member");
        string name = Console.ReadLine();
        Console.WriteLine("2. Enter email address");
        string email = Console.ReadLine();
        Console.WriteLine("3. Enter event name");
        string eventName = Console.ReadLine();
        Console.WriteLine("4. Enter number of attendees");
        int numberOfAttendees;
        while(!int.TryParse(Console.ReadLine(), out numberOfAttendees) || numberOfAttendees < 0)
        {
            Console.WriteLine("Number of attendees be greater than zero.");
        }
        Console.WriteLine("------------------END------------------");
        return (name, email, eventName, numberOfAttendees);
    }
    public static (string name, string description) MenuEvent()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("Add new event");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Enter name event");
        string name = Console.ReadLine();
        Console.WriteLine("2. Enter description event");
        string description = Console.ReadLine();
        Console.WriteLine("3. Exit");
        Console.WriteLine("------------------END------------------");
        return (name, description);
    }
    public static (string email, string eventName) MenuRemoveRegistration()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("Remove registered in list events");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Enter email address");
        string email = Console.ReadLine();
        Console.WriteLine("2. Enter name event");
        string eventName = Console.ReadLine();
        Console.WriteLine("3. Exit");
        Console.WriteLine("------------------END------------------");
        return (email, eventName);
    }
    public static (string name, string email) MenuSearchRegistration()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("Search registered events");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Enter name");
        string name = Console.ReadLine();
        Console.WriteLine("2. Enter email address");
        string email = Console.ReadLine();
        Console.WriteLine("3. Exit");
        Console.WriteLine("------------------END------------------");
        return (name, email);
    }
}