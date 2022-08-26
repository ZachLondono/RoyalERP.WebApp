namespace RoyalERP.WebApp.Shared.API.Companies;

public class Company {

    public Guid Id { get; set; }

    public int Version { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Contact { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public Address Address { get; set; } = new Address();

    public IEnumerable<DefaultConfiguration> Defaults { get; set; } = Enumerable.Empty<DefaultConfiguration>();

}
