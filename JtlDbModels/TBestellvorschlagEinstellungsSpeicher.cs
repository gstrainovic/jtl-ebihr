using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBestellvorschlagEinstellungsSpeicher
{
    public int KBenutzer { get; set; }

    public string XKonfiguration { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
