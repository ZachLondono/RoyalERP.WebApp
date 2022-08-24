namespace RoyalERP.WebApp.Shared.API.Products;

public class Product {

    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public Guid ClassId { get; set; }

    public IEnumerable<Guid> Attributes { get; set; } = Enumerable.Empty<Guid>();

}