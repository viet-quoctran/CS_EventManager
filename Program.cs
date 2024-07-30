namespace CS_EventManager;

class Program
{
    static void Main(string[] args)
    {
        EventManager eventManager = new EventManager();
        while(true)
        {
            int option = Menu.MenuMain();
            switch(option)
            { 
                case 1:
                    var registrationDetails = Menu.MenuRegistrations();
                    Registration registration = new Registration(registrationDetails.name, registrationDetails.email, registrationDetails.eventName, registrationDetails.numberOfAttendees);
                    eventManager.AddRegistration(registration);
                    break;
                case 2:
                    var eventDetails = Menu.MenuEvent();
                    EventDetail newEvent = new EventDetail(eventDetails.name, eventDetails.description);
                    eventManager.AddEvent(newEvent);
                    break;
                case 3:
                    var registrationDelete = Menu.MenuRemoveRegistration();
                    eventManager.RemoveRegistration(registrationDelete.email, registrationDelete.eventName);
                    break;
                case 4:
                    var registrationSearch = Menu.MenuSearchRegistration();
                    eventManager.SearchRegistration(registrationSearch.name, registrationSearch.email);
                    break;
                case 5:
                    eventManager.ListAllRegistrations();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }
    }
}
