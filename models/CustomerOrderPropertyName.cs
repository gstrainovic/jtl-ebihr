using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerOrderPropertyName
{
    public string CustomerOrderPropertyId { get; set; } = null!;

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
