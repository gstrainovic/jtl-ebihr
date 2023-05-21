using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerProperty
{
    public int CustomerId { get; set; }

    public string PropertyId { get; set; } = null!;

    public string CustomerPropertyId { get; set; } = null!;

    public string PropertyType { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
