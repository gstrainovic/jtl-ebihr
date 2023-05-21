using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStatistikAuswertungstyp
{
    public int KStatistikAuswertungstyp { get; set; }

    public string? CName { get; set; }

    public byte? NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
