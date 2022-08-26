using RoyalERP.WebApp.Shared.API.Companies;
using RoyalERP.WebApp.Shared.API.Events;
using RoyalERP.WebApp.Shared.API.Orders;
using RoyalERP.WebApp.Shared.API.ProductAttributes;
using RoyalERP.WebApp.Shared.API.ProductClasses;
using RoyalERP.WebApp.Shared.API.Products;
using RoyalERP.WebApp.Shared.API.WorkOrders;
using System;
using System.Runtime.InteropServices;

namespace RoyalERP.WebApp.Shared.API;

public class ExampleCompanyData : ICompanyAPI {

    private readonly List<Company> _companies = new();

    public ExampleCompanyData() {

        _companies.Add(new() {
            Id = Guid.Parse("21552A61-9F88-454F-A343-3406965BA3CF"),
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
            },
            Defaults = new List<DefaultConfiguration>() {
                new() {
                    ProductId = ExampleProductData.DrawerBoxId,
                    AttributeId = ExampleProductAttributeData.BoxMaterialId,
                    Value = "Economy Birch"
                },
                new() {
                    ProductId = ExampleProductData.DoorId,
                    AttributeId = ExampleProductAttributeData.MaterialId,
                    Value = "MDF 3/4\""
                }
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

        Guid drawerBoxId = ExampleProductClassData.DovetailId;
        var dbOrders = new List<WorkOrder>() { 
                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
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
                    ProductClass = drawerBoxId,
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                }

            };

        Guid doorClassId = ExampleProductClassData.MDFDoorId;
        var doorOrders = new List<WorkOrder>() {
                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
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
                    ProductClass = doorClassId,
                    Quantity = 10,
                    Status = "Pending",
                    ReleasedDate = DateTime.Today,
                    FulfilledDate = null,
                    ScheduledDate = null
                }

            };

        Guid closetClassId = ExampleProductClassData.ClosetPartId;
        var closetOrders = new List<WorkOrder>() {
                new() {
                    Id = Guid.NewGuid(),
                    SalesOrderId = Guid.NewGuid(),
                    Name = "Pending Order C",
                    Number = "000",
                    Note = "This is a note",
                    CustomerName = "Company A",
                    VendorName = "Company B",
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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
                    ProductClass = closetClassId,
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

    private readonly List<Event> _events = new();

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

public class ExampleProductData : IProductAPI {

    public readonly static Guid DoorId = new("88E7E7EF-1C94-42B5-9373-E9E0C5E5C338");
    public readonly static Guid DrawerBoxId = new("FB681987-45F7-42B7-A59B-83881CE338A3");
    public readonly static Guid ClosetId = new("32D8B615-5D47-4946-A89F-F733455C74AD");

    public readonly List<Product> _products;

    public ExampleProductData() {

        _products = new() {
            new() {
                Id = DoorId,
                Name = "MDF Door",
                ClassId = ExampleProductClassData.MDFDoorId,
                Attributes = new List<Guid>() {
                    ExampleProductAttributeData.MaterialId
                }
            },
            new() {
                Id = DrawerBoxId,
                Name = "Drawer Box",
                ClassId = ExampleProductClassData.DovetailId,
                Attributes = new List<Guid>() {
                    ExampleProductAttributeData.BoxMaterialId,
                    ExampleProductAttributeData.BottomMaterialId
                }
            },
            new() {
                Id = ClosetId,
                Name = "Closet Part",
                ClassId = ExampleProductClassData.ClosetPartId,
                Attributes = Enumerable.Empty<Guid>()
                
            }
        };

    }

    public Task<IEnumerable<Product>> GetAll() => Task.FromResult(_products.AsEnumerable());

    public Task<Product?> GetById(Guid productid) => Task.FromResult(_products.Where(p => p.Id.Equals(productid)).FirstOrDefault());

}

public class ExampleProductClassData : IProductClassAPI {

    private readonly List<ProductClass> _classes;

    public readonly static Guid DovetailId = new("CB732FC8-340A-4E63-8F5B-5E229D3261C7");
    public readonly static Guid ClosetPartId = new("CD3458F5-6F0C-414E-9972-0FB0FB120967");
    public readonly static Guid MDFDoorId = new("CD3458F6-6F0C-414E-9972-0FB0FB120967");

    public ExampleProductClassData() {

        _classes = new() {

            new() {
                Id = DovetailId,
                Name = "Dovetail Drawer Box"
            },

            new() {
                Id = ClosetPartId,
                Name = "Closet Part"
            },

            new() {
                Id = MDFDoorId,
                Name = "MDF Door"
            }

        };

    }

    public Task<IEnumerable<ProductClass>> GetAll() => Task.FromResult(_classes.AsEnumerable());

    public Task<ProductClass?> GetById(Guid id) => Task.FromResult(_classes.Where(c => c.Id.Equals(id)).FirstOrDefault());
}

public class ExampleProductAttributeData : IProductAttributeAPI {

    private readonly List<ProductAttribute> _attributes;
    
    public readonly static Guid BoxMaterialId = new("82B76341-BE26-43CC-A238-9F20E81EA461");
    public readonly static Guid BottomMaterialId = new("72B76341-BE26-43CC-A238-9F20E81EA461");
    public readonly static Guid MaterialId = new("62B76341-BE26-43CC-A238-9F20E81EA461");

    public ExampleProductAttributeData() {

        _attributes = new();
        
        _attributes.Add(new() {
            Id = MaterialId,
            Name = "Material"
        });

        _attributes.Add(new() {
            Id = BoxMaterialId,
            Name = "Box Material"
        });

        _attributes.Add(new() {
            Id = BottomMaterialId,
            Name = "Bottom Material"
        });

    }

    public Task<IEnumerable<ProductAttribute>> GetAll() => Task.FromResult(_attributes.AsEnumerable());

    public Task<ProductAttribute?> GetById(Guid id) => Task.FromResult(_attributes.Where(a => a.Id.Equals(id)).FirstOrDefault());

}