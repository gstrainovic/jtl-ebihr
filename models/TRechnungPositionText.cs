using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungPositionText
{
    public int KRechnungPosition { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TRechnungPosition KRechnungPositionNavigation { get; set; } = null!;
}
