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

}