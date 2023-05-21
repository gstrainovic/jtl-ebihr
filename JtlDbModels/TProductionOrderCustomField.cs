using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductionOrderCustomField
{
    public int KProductionOrderCustomField { get; set; }

    public int KProductionOrder { get; set; }

    public int KAttribut { get; set; }

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
