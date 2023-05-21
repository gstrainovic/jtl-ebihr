using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class WarehouseArea
{
    public int WarehouseAreaId { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public int WarehouseId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
