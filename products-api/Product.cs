using System;

namespace products_api;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int Price { get; set; }
}
