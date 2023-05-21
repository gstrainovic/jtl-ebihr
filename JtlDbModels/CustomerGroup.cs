using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerGroup
{
    public int CustomerGroupId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
