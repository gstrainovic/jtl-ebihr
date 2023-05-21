using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ShippingMethodName
{
    public int ShippingMethodId { get; set; }

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
