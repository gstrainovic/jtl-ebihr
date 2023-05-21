using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRechnungText
{
    public int KRechnung { get; set; }

    public string? CRechnungstext { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
