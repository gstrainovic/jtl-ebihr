using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TResourceCustomField
{
    public int KResourceCustomField { get; set; }

    public int KResource { get; set; }

    public int KAttribut { get; set; }

    public string? CWertVarchar { get; set; }

    public int? NWertInt { get; set; }

    public decimal? FWertDecimal { get; set; }

    public DateTime? DWertDateTime { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAttribut KAttributNavigation { get; set; } = null!;

    public virtual TResource KResourceNavigation { get; set; } = null!;
}
