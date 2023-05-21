using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungPositionEigenschaft
{
    public int KRechnungPositionEigenschaft { get; set; }

    public int? KEigenschaftWert { get; set; }

    public int KRechnungPosition { get; set; }

    public int? KEigenschaft { get; set; }

    public decimal FAufpreisNetto { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public string CWert { get; set; } = null!;

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
