using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CarrierName
{
    public int CarrierId { get; set; }

    public string LanguageIso { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[]? LastChange { get; set; }
}
