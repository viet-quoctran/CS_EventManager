using System.ComponentModel;

namespace CS_EventManager;
class Registration
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string EventName { get; set; }
    private int numberOfAttendees;
    public int NumberOfAttendees
    {
        get => numberOfAttendees;
        set
        {
            if ( value < 1 ) throw new ArgumentException("Number of attendees must be greater than zero.");
            numberOfAttendees = value;
        }
    }
    public Registration(string name, string email, string eventName, int numberOfAttendees)
    {
        Name = name;
        Email = email;
        EventName = eventName;
        NumberOfAttendees = numberOfAttendees;
    }

}