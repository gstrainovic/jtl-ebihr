using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenLagerPrioGlobal
{
    public int KWarenLager { get; set; }

    public int KVertriebsweg { get; set; }

    public int? NPrio { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
