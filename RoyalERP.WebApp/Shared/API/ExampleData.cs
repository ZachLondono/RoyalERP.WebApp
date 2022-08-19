using RoyalERP.WebApp.Shared.API.Companies;
using RoyalERP.WebApp.Shared.API.Events;
using RoyalERP.WebApp.Shared.API.Orders;
using RoyalERP.WebApp.Shared.API.WorkOrders;

namespace RoyalERP.WebApp.Shared.API;

public class ExampleCompanyData : ICompanyAPI {

    private readonly List<Company> _companies = new();

    public ExampleCompanyData() {

        _companies.Add(new() {
            Id = Guid.NewGuid(),
            Name = "Company A",
            Contact = "John",
            Email = "abc@def.com",
            Address = new() {
                Line1 = "",
                Line2 = "",
                Line3 = "",
                City = "",
                State = "",
                Zip = ""
            }
        });

        _companies.Add(new() {
            Id = Guid.NewGuid(),
            Name = "Company B",
            Contact = "Bob",
            Email = "abc@def.com",
            Address = new() {
                Line1 = "",
                Line2 = "",
                Line3 = "",
                City = "",
                State = "",
                Zip = ""
            }
        });

        _companies.Add(new() {
            Id = Guid.NewGuid(),
            Name = "Company C",
            Contact = "Sally",
            Email = "abc@def.com",
            Address = new() {
                Line1 = "",
                Line2 = "",
                Line3 = "",
                City = "",
                State = "",
                Zip = ""
            }
        });

    }

    public Task<IEnumerable<Company>> GetAll() => Task.FromResult(_companies.AsEnumerable());

    public Task<Company> GetById(Guid id) => Task.FromResult(_companies.Where(c => c.Id == id).First());

}

public class ExampleOrderData : IOrderAPI {

    public Task<IEnumerable<OrderSummary>> GetAll() {
        throw new NotImplementedException();
    }

    public Task<OrderDetails> GetById(Guid id) {
        throw new NotImplementedException();
    }

}

public class ExampleWorkOrderData : IWorkOrderAPI {

    private readonly List<WorkOrder> _workOrders;

    public ExampleWorkOrderData() {

        _workOrders = new();

        var dbOrders = new List<WorkOrder>() { 
                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order A",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(5)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order B",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(3)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(15)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order D",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Future Order",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(-15).AddYears(1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order E",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Late Order",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = DateTime.Today.AddDays(-1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order  A",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = null
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order  B",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Drawer Box",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                }

            };

        var doorOrders = new List<WorkOrder>() {
                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order A",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(5)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order B",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(3)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(15)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order D",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Future Order",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(-15).AddYears(1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order E",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Late Order",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = DateTime.Today.AddDays(-1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order  A",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = null
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order  B",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "MDF Door",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                }

            };

        var closetOrders = new List<WorkOrder>() {
                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order A",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(5)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order B",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(3)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(15)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order D",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Future Order",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today.AddDays(-15).AddYears(1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Scheduled Order E",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = DateTime.Today
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Late Order",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "InProgress",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = DateTime.Today.AddDays(-1)
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order  A",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = DateTime.Today,
                    ScheduledDate = null
                },

                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order  B",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductName = "Closet Part",
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                }

            };

        _workOrders.AddRange(dbOrders);
        _workOrders.AddRange(doorOrders);
        _workOrders.AddRange(closetOrders);

    }

    public Task<IEnumerable<WorkOrder>> GetAll() => Task.FromResult(_workOrders.AsEnumerable());

    public Task<IEnumerable<WorkOrder>> GetAllScheduledOnDate(DateTime date) =>
        Task.FromResult(_workOrders.Take(new Random().Next(0, _workOrders.Count)));

    public Task<WorkOrder> GetById(Guid id) => Task.FromResult(_workOrders.Where(o => o.Id == id).First());

}

public class ExampleEventData : IEventAPI {

    private List<Event> _events = new();

    public ExampleEventData() {

        _events.Add(new() {
            Id = Guid.NewGuid(),
            Summary = "Order OT000 was completed",
            Timestamp = DateTime.Today.AddHours(-1.25),
        });

        _events.Add(new() {
            Id = Guid.NewGuid(),
            Summary = "Order OT000 was released",
            Timestamp = DateTime.Today.AddHours(-1).AddDays(-1),
        });

        _events.Add(new() {
            Id = Guid.NewGuid(),
            Summary = "Order OT000 was confirmed",
            Timestamp = DateTime.Today.AddHours(-1.25).AddDays(-1),
        });

        _events.Add(new() {
            Id = Guid.NewGuid(),
            Summary = "New order OT000 placed",
            Timestamp = DateTime.Today.AddHours(-5.25).AddDays(-1),
        });

    }

    public Task<IEnumerable<Event>> GetAll() => Task.FromResult(_events.AsEnumerable());

    public Task<IEnumerable<Event>> GetByAggregateId(Guid AggregateId) {
        throw new NotImplementedException();
    }

    public Task<Event> GetById(Guid Id) {
        throw new NotImplementedException();
    }
}
