using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLaufendeNummern
{
    public int KLaufendeNummer { get; set; }

    public string? CName { get; set; }

    public int? NNummer { get; set; }

    public string? CPrefix { get; set; }

    public string? CSuffix { get; set; }

    public int? KFirma { get; set; }

    public string? CTable { get; set; }

    public string? CColumn { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CTypeColumn { get; set; }

    public string? CTypeValue { get; set; }

    public string? CAnzeigename { get; set; }
}
