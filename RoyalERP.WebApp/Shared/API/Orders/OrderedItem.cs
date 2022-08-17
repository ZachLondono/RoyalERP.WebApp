namespace RoyalERP.WebApp.Shared.API.Orders;

public class OrderedItem {

    public Guid Id { get; set; }

    public string ProductName { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public Dictionary<string, string> Properties { get; set; } = new();

}