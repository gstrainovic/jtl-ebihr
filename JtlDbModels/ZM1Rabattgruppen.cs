using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ZM1Rabattgruppen
{
    public int KRabattGruppe { get; set; }

    public string? CName { get; set; }

    public int? NS1 { get; set; }

    public int? NR1 { get; set; }

    public int? NS2 { get; set; }

    public int? NR2 { get; set; }

    public int? NS3 { get; set; }

    public int? NR3 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
