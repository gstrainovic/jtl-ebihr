using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLagerArtikel
{
    public int KLagerArtikel { get; set; }

    public int? KLager { get; set; }

    public int? KLagerOrt { get; set; }

    public int? KArtikel { get; set; }

    public string? CSeriennr { get; set; }

    public decimal FEk { get; set; }

    public string? CBeschreibung1 { get; set; }

    public string? CBeschreibung2 { get; set; }

    public int? KBestellPos { get; set; }

    public int? KLieferscheinPos { get; set; }

    public int? KLieferant { get; set; }

    public int? KWarenlager { get; set; }

    public int? KLieferantenbestellung { get; set; }

    public int KPicklistePos { get; set; }

    public int? KRmretourePos { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
