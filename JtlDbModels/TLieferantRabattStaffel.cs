using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferantRabattStaffel
{
    public int KLieferantStaffelPreis { get; set; }

    public int KLieferant { get; set; }

    public decimal FAb { get; set; }

    public decimal FRabatt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
