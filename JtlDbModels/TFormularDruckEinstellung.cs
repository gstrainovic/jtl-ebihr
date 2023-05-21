using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFormularDruckEinstellung
{
    public int KFormularDruckEinstellung { get; set; }

    public int KFormular { get; set; }

    public string? CRechnername { get; set; }

    public int? KBenutzer { get; set; }

    public string CDruckername1 { get; set; } = null!;

    public int NKopien1 { get; set; }

    public string CDruckername2 { get; set; } = null!;

    public int NKopien2 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
