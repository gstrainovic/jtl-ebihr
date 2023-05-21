using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFile1
{
    public int KFile { get; set; }

    public int KReferenz { get; set; }

    public byte NReferenztyp { get; set; }

    public byte[]? BData { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public string? CFileName { get; set; }
}
