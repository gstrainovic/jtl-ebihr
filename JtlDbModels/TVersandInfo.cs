using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandInfo
{
    public int KBestellung { get; set; }

    public int? NAnzahlVersendetePakete { get; set; }

    public int? NAnzahlPakete { get; set; }

    public DateTime? DVersanddatum { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
