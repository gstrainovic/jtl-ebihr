using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStatistikVorlageOrdner
{
    public int KStatistikVorlageOrdner { get; set; }

    public int KStatistikVorlageOrdnerParent { get; set; }

    public string? CName { get; set; }

    public byte? NIntern { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
