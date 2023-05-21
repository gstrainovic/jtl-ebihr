using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerOrderProperty
{
    public int CustomerOrderId { get; set; }

    public string? PropertyId { get; set; }

    public string CustomerOrderPropertyId { get; set; } = null!;

    public string PropertyType { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
