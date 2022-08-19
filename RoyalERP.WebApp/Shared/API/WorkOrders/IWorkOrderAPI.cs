using Refit;

namespace RoyalERP.WebApp.Shared.API.WorkOrders;

[Headers("X-Api-Key:A1C33C48-CF3A-4DAB-8EB3-CB76976B5690")]
public interface IWorkOrderAPI {

    [Get("/workorders")]
    public Task<IEnumerable<WorkOrder>> GetAll();
    
    [Get("/workorders/{id}")]
    public Task<WorkOrder> GetById(Guid id);

    [Get("/workorders?scheduleddate={date}")]
    public Task<IEnumerable<WorkOrder>> GetAllScheduledOnDate(DateTime date);

}