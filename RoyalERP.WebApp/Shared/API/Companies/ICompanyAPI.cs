using Refit;

namespace RoyalERP.WebApp.Shared.API.Companies;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface ICompanyAPI {

    [Get("/companies")]
    public Task<IEnumerable<Company>> GetAll();

    [Get("/companies/{id}")]
    public Task<Company> GetById(Guid id);

    [Post("/companies")]
    public Task<Company> Create([Body] NewCompany newCompany);

    [Put("/companies/{companyId}")]
    public Task<Company> Update(Guid companyId, [Body] UpdateCompany companyData);

}
