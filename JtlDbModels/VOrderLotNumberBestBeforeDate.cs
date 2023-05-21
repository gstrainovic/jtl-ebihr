using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderLotNumberBestBeforeDate
{
    public int KOrder { get; set; }

    public int KOrderPos { get; set; }

    public decimal FQuantity { get; set; }

    public string? CLotNumber { get; set; }

    public DateTime? DBestBeforeDate { get; set; }
}
