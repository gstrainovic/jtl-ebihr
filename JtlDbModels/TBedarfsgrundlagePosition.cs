using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBedarfsgrundlagePosition
{
    public int KBedarfsgrundlagePos { get; set; }

    public int KBedarfsgrundlage { get; set; }

    public int NPrio { get; set; }

    public int? KWarenlager { get; set; }

    public byte NTyp { get; set; }

    public int? KWmslagerbereich { get; set; }

    public int? KWarenlagerplatz { get; set; }

    public int? KLieferant { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
