using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelAttributEigeneFelder
{
    public int KArtikelAttribut { get; set; }

    public int KSprache { get; set; }

    public int NSortierung { get; set; }

    public int KArtikel { get; set; }

    public string CName { get; set; } = null!;

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte NDatenTyp { get; set; }
}
