using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ShippingClass
{
    public int ShippingClassId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
