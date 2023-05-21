using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CategoryProperty
{
    public int CategoryId { get; set; }

    public string? PropertyId { get; set; }

    public string CategoryPropertyId { get; set; } = null!;

    public string PropertyType { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
