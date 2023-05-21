using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TKundeEigenesFeld
{
    public int KKundeEigenesFeld { get; set; }

    public int KKunde { get; set; }

    public int KAttribut { get; set; }

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAttribut KAttributNavigation { get; set; } = null!;
}
