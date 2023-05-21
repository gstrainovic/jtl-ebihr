using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ProductComponent
{
    public int ComponentProductId { get; set; }

    public int ProductId { get; set; }

    public decimal Amount { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
