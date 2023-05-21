using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDruckEinstellung
{
    public int KDruckEinstellung { get; set; }

    public int KBenutzer { get; set; }

    public string CArbeitsplatz { get; set; } = null!;

    public int KDruckvorlage { get; set; }

    public string CDruckername1 { get; set; } = null!;

    public string CDruckername2 { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
