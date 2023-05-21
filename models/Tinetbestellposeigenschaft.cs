using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tinetbestellposeigenschaft
{
    public int KInetBestellPosEigenschaft { get; set; }

    public int? KInetBestellPos { get; set; }

    public int? KEigenschaft { get; set; }

    public int? KEigenschaftWert { get; set; }

    public decimal FAufpreis { get; set; }

    public string? CWert { get; set; }

    public int KShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
