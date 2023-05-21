using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProdItemCustomField
{
    public int KProdItemCustomField { get; set; }

    public int KArtikel { get; set; }

    public int KAttribut { get; set; }

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
