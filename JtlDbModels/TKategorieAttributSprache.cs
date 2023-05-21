using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKategorieAttributSprache
{
    public int KKategorieAttribut { get; set; }

    public int KSprache { get; set; }

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
