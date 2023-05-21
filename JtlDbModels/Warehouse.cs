using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public int? CompanyId { get; set; }

    public string? Code { get; set; }

    public string? WarehouseName { get; set; }

    public string WarehouseType { get; set; } = null!;

    public string? CountryIso { get; set; }

    public string? Country { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
