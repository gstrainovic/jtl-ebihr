using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerGroupProperty
{
    public int CustomerGroupId { get; set; }

    public string? PropertyId { get; set; }

    public string CustomerGroupPropertyId { get; set; } = null!;

    public string PropertyType { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
