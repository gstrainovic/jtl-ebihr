using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TZustandWarengruppe
{
    public int KZustandWarengruppe { get; set; }

    public int KZustand { get; set; }

    public int KWarengruppe { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
