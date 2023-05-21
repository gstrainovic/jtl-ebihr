using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAuftragsverwaltungDetail
{
    public int KAuftrag { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CSonstiges { get; set; }

    public int NStornogrund { get; set; }

    public string CStornobenutzer { get; set; } = null!;

    public DateTime? DStornozeitpunkt { get; set; }
}
