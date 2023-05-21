using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Webshop
{
    public int ShopId { get; set; }

    public string? ShopName { get; set; }

    public int? CompanyId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
