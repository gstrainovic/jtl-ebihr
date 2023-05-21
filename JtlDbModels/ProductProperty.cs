using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ProductProperty
{
    public int ProductId { get; set; }

    public int PropertyId { get; set; }

    public string PropertyNameType { get; set; } = null!;

    public string PropertyType { get; set; } = null!;

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public string? ValueName { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
