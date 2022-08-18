namespace RoyalERP.WebApp.Shared.API.Events;

public class Event {

    public Guid Id { get; set; }

    public string EventType { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public DateTime Timestamp { get; set; }

    public Dictionary<string, string> Properties { get; set; } = new();

}