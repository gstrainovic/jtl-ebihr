using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAuftragsposition1
{
    public int KBestellung { get; set; }

    public int KBestellPos { get; set; }

    public int? KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CArtikelbezeichnung { get; set; }

    public int KWarenlager { get; set; }

    public decimal FAuftragsmenge { get; set; }

    public int NSort { get; set; }

    public decimal FBereitsGeliefert { get; set; }

    public decimal FOffeneAuftragsmenge { get; set; }

    public decimal? FGesamtbestand { get; set; }

    public decimal FFehlbestand { get; set; }

    public decimal FFehlbestandEigen { get; set; }

    public string? CHinweis { get; set; }

    public int NLieferbarStatus { get; set; }

    public int NLieferbarStatusEigen { get; set; }

    public int NIstFreiposition { get; set; }

    public int NIstLagerartikel { get; set; }

    public int NHatLagerbestandInVariationen { get; set; }

    public int KStuecklistenVater { get; set; }

    public int? KKonfigurationsVater { get; set; }

    public decimal? FZulauf { get; set; }

    public decimal FAnzahlAufPicklisten { get; set; }

    public decimal FBestandWms { get; set; }

    public decimal FReserviert { get; set; }

    public decimal FReserviertEigen { get; set; }

    public decimal? FVerfuegbarGesperrt { get; set; }

    public decimal? FAuslieferungGesperrt { get; set; }
}
