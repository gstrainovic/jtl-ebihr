using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvBestellPositionen
{
    public int KBestellung { get; set; }

    public int KBestellungPos { get; set; }

    public int KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CLieferantenArtNr { get; set; }

    public int NSort { get; set; }

    public string? CName { get; set; }

    public string? CNameLief { get; set; }

    public decimal FUst { get; set; }

    public decimal FMenge { get; set; }

    public decimal FMengeGeliefert { get; set; }

    public decimal FEknetto { get; set; }

    public decimal FEknettoArtikel { get; set; }

    public decimal? FEkNettoGesamt { get; set; }

    public string? CHinweis { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public int? NPosTyp { get; set; }

    public string? CHan { get; set; }

    public string? CKommentar { get; set; }
}
