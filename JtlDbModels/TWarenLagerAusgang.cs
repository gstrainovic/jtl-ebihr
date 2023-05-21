using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLagerAusgang
{
    public int KWarenLagerEingang { get; set; }

    public int KLieferscheinPos { get; set; }

    public decimal FAnzahl { get; set; }

    public int KWarenLagerAusgang { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public int KArtikel { get; set; }

    public string? CKommentar { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? KBenutzer { get; set; }

    public int KBuchungsart { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KSessionId { get; set; }
}
