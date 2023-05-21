using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Stocktaking
{
    public int StocktakingId { get; set; }

    public int BinLocationId { get; set; }

    public int ProductId { get; set; }

    public decimal StockAmount { get; set; }

    public DateTime? BestBeforeDate { get; set; }

    public string? BatchName { get; set; }

    public string? SerialNumber { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
