using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerPropertyName
{
    public string CustomerPropertyId { get; set; } = null!;

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
