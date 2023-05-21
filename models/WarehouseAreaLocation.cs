using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class WarehouseAreaLocation
{
    public int WarehouseAreaLocationId { get; set; }

    public int WarehouseAreaId { get; set; }

    public int BinLocationId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
