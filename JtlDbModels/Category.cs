using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Category
{
    public int CategoryId { get; set; }

    public int? ParentCategoryId { get; set; }

    public int? Sorting { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
