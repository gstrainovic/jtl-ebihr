using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvLieferscheinWarenlagerausgang
{
    public int KLieferschein { get; set; }

    public int KLieferscheinPos { get; set; }

    public int? KWarenLagerAusgang { get; set; }

    public decimal? FAnzahl { get; set; }

    public DateTime? DMhd { get; set; }

    public string? CChargenNr { get; set; }

    public string? CWarenlagerName { get; set; }

    public byte NIstWmslager { get; set; }

    public string? CLagerplatz { get; set; }
}
