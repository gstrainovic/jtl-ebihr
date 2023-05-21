using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferantenBestellungPo
{
    public int KLieferantenBestellungPos { get; set; }

    public int KLieferantenBestellung { get; set; }

    public int KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CLieferantenArtNr { get; set; }

    public string? CName { get; set; }

    public string? CLieferantenBezeichnung { get; set; }

    public decimal FUst { get; set; }

    public decimal FMenge { get; set; }

    public string? CHinweis { get; set; }

    public decimal FEknetto { get; set; }

    public int? NPosTyp { get; set; }

    public string? CNameLieferant { get; set; }

    public int? NLiefertage { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public int NSort { get; set; }

    public int KLieferscheinPos { get; set; }

    public string? CVpeeinheit { get; set; }

    public decimal? NVpemenge { get; set; }

    public decimal FMengeGeliefert { get; set; }

    public decimal FAnzahlOffen { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
