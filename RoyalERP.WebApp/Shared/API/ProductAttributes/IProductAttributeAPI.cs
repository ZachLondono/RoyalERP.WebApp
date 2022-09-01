using Refit;

namespace RoyalERP.WebApp.Shared.API.ProductAttributes;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface IProductAttributeAPI {

    [Get("/attributes")]
    public Task<IEnumerable<ProductAttribute>> GetAll();

    [Get("/attributes/{id}")]
    public Task<ProductAttribute?> GetById(Guid id);

    [Post("attributes/")]
    public Task<ProductAttribute?> Create([Body] NewProductAttribute newAttribute);

    [Put("attributes/{id}")]
    public Task<ProductAttribute?> Update(Guid id, [Body] ProductAttributeUpdate updatedAttribute);

    [Delete("attributes/{id}")]
    public Task Delete(Guid id);

}