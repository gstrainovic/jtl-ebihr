using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerCategory
{
    public int CustomerCategoryId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
