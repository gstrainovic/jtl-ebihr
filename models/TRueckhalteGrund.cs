using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRueckhalteGrund
{
    public int KRueckhalteGrund { get; set; }

    public string CName { get; set; } = null!;

    public byte NZusammenfassbar { get; set; }

    public byte NEinkaufslisteGesperrt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
