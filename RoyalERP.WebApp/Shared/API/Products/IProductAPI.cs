using Refit;

namespace RoyalERP.WebApp.Shared.API.Products;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface IProductAPI {

    [Get("/products")]
    public Task<IEnumerable<Product>> GetAll();

    [Get("/products/{productid}")]
    public Task<Product?> GetById(Guid productid);

    [Delete("/products/{productId}")]
    public Task Delete(Guid productId);

    [Post("/products")]
    public Task<Product?> Create(NewProduct newProduct);

    [Post("/products/{productId}")]
    public Task<Product?> Update(Guid productId, ProductUpdate update);

    [Put("/products/{productId}/attributes")]
    public Task<Product?> AddAttribute(Guid productId, ProductAttributeAdd attribute);

    [Delete("/products/{productId}/attributes/{attributeId}")]
    public Task<Product?> RemoveAttribute(Guid productId, Guid attributeId);

    [Put("/products/{productId}/class/")]
    public Task<Product?> SetClass(Guid productId, ProductClassAdd prodClass);

    [Delete("/products/{productId}/class")]
    public Task<Product?> RemoveClass(Guid productId);

}