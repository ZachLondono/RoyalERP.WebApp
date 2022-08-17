using Refit;

namespace RoyalERP.WebApp.Shared.API.Orders;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface IOrderAPI {

    [Get("/orders")]
    public Task<IEnumerable<OrderSummary>> GetAll();

    [Get("/orders/{id}")]
    public Task<OrderDetails> GetById(Guid id);

}
