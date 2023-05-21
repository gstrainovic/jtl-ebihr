using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CountryName
{
    public string CountryId { get; set; } = null!;

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
