using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZahlungsArtSprache
{
    public int KZahlungsart { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public string? CPrtString { get; set; }

    public string? CPrtStringVor { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
