using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteVorlageEigeneFelder
{
    public int KPicklisteVorlage { get; set; }

    public int KAttribut { get; set; }

    public string? CWert { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }
}
