namespace RoyalERP.WebApp.Shared.API.Events;

public interface IEventAPI {

    public Task<IEnumerable<Event>> GetAll();

    public Task<Event> GetById(Guid Id);

    public Task<IEnumerable<Event>> GetByAggregateId(Guid AggregateId);

}
