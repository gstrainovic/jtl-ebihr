using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerGroupPropertyName
{
    public string CustomerGroupPropertyId { get; set; } = null!;

    public string? LanguageIso { get; set; }

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
