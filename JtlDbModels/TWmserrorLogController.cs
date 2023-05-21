using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWmserrorLogController
{
    public int NProzess { get; set; }

    public string CQuelle { get; set; } = null!;

    public byte NAktiv { get; set; }

    public int NLevel { get; set; }

    public string? CArbeitsPlatz { get; set; }

    public int? KBenutzer { get; set; }

    public int NSaveMethod { get; set; }

    public DateTime DStartZeit { get; set; }

    public DateTime DEndZeit { get; set; }

    public int KWarenlager { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
