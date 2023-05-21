using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class BinLocation1
{
    public int InternalId { get; set; }

    public decimal MaximumWeight { get; set; }

    public string? Comment { get; set; }

    public decimal Length { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public int? Sorting { get; set; }

    public string? BinLocatinName { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? InventoryDate { get; set; }

    public byte IsLocked { get; set; }

    public int WarehouseInternalId { get; set; }
}
