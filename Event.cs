namespace CS_EventManager;
class EventDetail  
{
    public string EventName { get; set; }
    public string Description { get; set; }
    public EventDetail  (string name, string description)
    {
        EventName = name;
        Description = description;
    }
}