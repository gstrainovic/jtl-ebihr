using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class BinLocation
{
    public int BinLocationId { get; set; }

    public int WarehouseId { get; set; }

    public int? BinLocationTypeId { get; set; }

    public int? StocktakingId { get; set; }

    public string? BinLocationName { get; set; }

    public string? BinLocationComment { get; set; }

    public decimal BinLength { get; set; }

    public decimal BinHeight { get; set; }

    public decimal BinWidth { get; set; }

    public decimal BinMaxWeight { get; set; }

    public DateTime? LastStocktakingDate { get; set; }

    public bool IsLocked { get; set; }

    public byte IsUsedForAvialableStock { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
