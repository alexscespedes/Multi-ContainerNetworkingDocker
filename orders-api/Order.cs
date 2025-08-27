using System;

namespace orders_api;

public class Order
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public string? Description { get; set; }
}
