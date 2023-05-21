using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFirmaEigenesFeld
{
    public int KFirmaEigenesFeld { get; set; }

    public int KFirma { get; set; }

    public int KAttribut { get; set; }

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
