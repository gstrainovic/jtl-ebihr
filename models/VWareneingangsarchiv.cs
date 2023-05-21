using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VWareneingangsarchiv
{
    public int KWarenLagerEingang { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CLiefArtNr { get; set; }

    public string? CArtikelname { get; set; }

    public string? CArtikelnummer { get; set; }

    public int? KWarenLager { get; set; }

    public string? CWarenLager { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public string? CWarenLagerPlatz { get; set; }

    public string? CEigeneBestellnummer { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public string? CBestellkommentar { get; set; }

    public string? CBenutzername { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FEkeinzel { get; set; }

    public string? CLieferantFirma { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? CChargenNr { get; set; }

    public DateTime? DMhd { get; set; }

    public DateTime? DGeliefertAm { get; set; }
}
