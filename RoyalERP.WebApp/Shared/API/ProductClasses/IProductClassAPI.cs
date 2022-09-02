using Refit;

namespace RoyalERP.WebApp.Shared.API.ProductClasses;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface IProductClassAPI {

    [Get("/productclasses")]
    public Task<IEnumerable<ProductClass>> GetAll();

    [Get("/productclasses/{id}")]
    public Task<ProductClass?> GetById(Guid id);

    [Post("/productclasses")]
    public Task<ProductClass> Create([Body] NewProductClass newClass);

    [Delete("/productclasses/{id}")]
    public Task Delete(Guid id);

    [Put("/productclasses/{id}")]
    public Task<ProductClass> Update(Guid id, [Body] ProductClassUpdate update);

}