using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ShippingMethod
{
    public int ShippingMethodId { get; set; }

    public decimal ShippingCost { get; set; }

    public decimal PackageInsuranceSum { get; set; }

    public decimal PackagingCost { get; set; }

    public int? CarrierId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
