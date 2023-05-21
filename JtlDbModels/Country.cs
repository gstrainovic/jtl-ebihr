using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Country
{
    public string CountryId { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
