using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandtoolDruckEinstellung
{
    public int KVersandtoolDruckEinstellung { get; set; }

    public byte NVersandSchnittstelle { get; set; }

    public string CRechnername { get; set; } = null!;

    public int? KBenutzer { get; set; }

    public string CDruckername { get; set; } = null!;

    public byte? NPageScaling { get; set; }

    public byte? NOrientation { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
