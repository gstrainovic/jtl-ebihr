using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ProductState
{
    public int ProductStateId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
