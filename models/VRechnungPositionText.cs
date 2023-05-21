using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRechnungPositionText
{
    public int KRechnungPosition { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
