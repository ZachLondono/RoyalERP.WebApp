﻿namespace RoyalERP.WebApp.Shared.API.Orders;

public class OrderSummary {

    public Guid Id { get; set; }

    public string Number { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public Guid CustomerId { get; set; } = Guid.Empty;

    public Guid VendorId { get; set; } = Guid.Empty;

    public DateTime PlacedDate { get; set; }

    public DateTime? ConfirmedDate { get; set; } = null;

    public DateTime? CompletedDate { get; set; } = null;

    public string Status { get; set; } = string.Empty;

}
