using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatistikvorlagenserialisierung
{
    public int KStatistikvorlagenserialisierung { get; set; }

    public int KBenutzer { get; set; }

    public string CAuswertungsvorlage { get; set; } = null!;

    public string CDarstellungsvorlage { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string? CBeschreibung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
