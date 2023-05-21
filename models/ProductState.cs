using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ProductState
{
    public int ProductStateId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
