using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace CS_EventManager;
class EventManager
{
    public List<Registration> Registrations { get; private set; }
    public List<EventDetail> Events { get; private set; }
    public EventManager()
    {
        Registrations = new List<Registration>();
    }
    public void AddEvent(EventDetail eventItem)
    {
        Events.Add(eventItem);
    }
    public void AddRegistration(Registration registration)
    {
        Registrations.Add(registration);
        Console.WriteLine("Adder registration: " + registration.Name + " successfully");
    }
    public void RemoveRegistration(string email, string eventName)
    {
        Registration registration = Registrations.Find(r => r.Email == email && r.EventName == eventName);
        if (registration != null)
        {
            Registrations.Remove(registration);
            Console.WriteLine("Removed registration: " + registration.Name + " successfully");
        }
        else
        {
            Console.WriteLine("No registration found for email: " + email + " and event: " + eventName);
        }
    }
    public void SearchRegistration(string name, string email)
    {
        Registration registration = Registrations.Find(r => r.Name == name && r.Email == email);
        if (registration!= null)
        {
            Console.WriteLine("Search registration: " + registration.Name + " found");
        }
        else
        {
            Console.WriteLine("No registration found for name: " + name + " and email: " + email);
        }
    }
    public void ListAllRegistrations()
    {
        Console.WriteLine("List of all registrations:");
        foreach (var registration in Registrations)
        {
            Console.WriteLine("Name : " + registration.Name + " Email : " + registration.Email + " Event : " + registration.EventName + " Number of Attends : " + registration.NumberOfAttendees);
        }
    }

}