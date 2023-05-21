using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VMerchantProductAttribute
{
    public int KArtikel { get; set; }

    public int KAttribut { get; set; }

    public string CName { get; set; } = null!;

    public string? CFfnName { get; set; }

    public string CFeldTyp { get; set; } = null!;

    public string Ffntyp { get; set; } = null!;

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }
}
