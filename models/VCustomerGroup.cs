using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VCustomerGroup
{
    public int KCustomerGroup { get; set; }

    public string? CName { get; set; }

    public byte? NStandard { get; set; }

    public decimal FDiscountPercent { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }
}
