using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVorgangsfarbe
{
    public int KVorgangsfarbe { get; set; }

    public string CBedeutung { get; set; } = null!;

    public byte? NRotwert { get; set; }

    public byte? NGruenwert { get; set; }

    public byte? NBlauwert { get; set; }

    public byte? NAlphawert { get; set; }

    public bool? NAngebot { get; set; }

    public bool? NAuftrag { get; set; }

    public bool? NRechnung { get; set; }

    public bool? NRechnungskorrektur { get; set; }

    public bool? NAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
