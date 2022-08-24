using Refit;

namespace RoyalERP.WebApp.Shared.API.ProductAttributes;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface IProductAttributeAPI {

    [Get("/productclasses")]
    public Task<IEnumerable<ProductAttribute>> GetAll();

    [Get("/productclasses/{id}")]
    public Task<ProductAttribute?> GetById(Guid id);

}