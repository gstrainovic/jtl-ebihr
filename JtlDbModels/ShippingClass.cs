using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ShippingClass
{
    public int ShippingClassId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
