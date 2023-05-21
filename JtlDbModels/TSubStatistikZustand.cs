using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSubStatistikZustand
{
    public int KBenutzer { get; set; }

    public byte KSubStatistik { get; set; }

    public string CWert { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
