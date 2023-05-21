using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvEinkaufsliste
{
    public int KArtikel { get; set; }

    public int KSteuerklasse { get; set; }

    public decimal FArtikelGld { get; set; }

    public int KLieferant { get; set; }

    public string? CHinweis { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FEknettoAktuell { get; set; }

    public int NLieferzeit { get; set; }

    public string? CLiefArtNr { get; set; }

    public string? CNameBeimLieferanten { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public string? CLieferantName { get; set; }

    public string? CWaehrungIso { get; set; }

    public decimal FLiefBestand { get; set; }

    public decimal FFehlbestand { get; set; }

    public decimal FVerfuegbar { get; set; }

    public decimal FMindestbestand { get; set; }

    public decimal FMindestbestandGlobal { get; set; }

    public int? KLieferantStd { get; set; }

    public string? CLieferantStd { get; set; }

    public int? KLieferantSchnellster { get; set; }

    public string? CLieferantSchnellster { get; set; }

    public int? KLieferantGuenstigster { get; set; }

    public string? CLieferantGuenstigster { get; set; }

    public string? CBarcode { get; set; }

    public int NMindestAbnahme { get; set; }

    public decimal FAbnahmeIntervall { get; set; }

    public string? CNameBenutzer { get; set; }

    public DateTime DErstellt { get; set; }

    public decimal FReserviert { get; set; }

    public decimal FZulauf { get; set; }

    public decimal FLagerbestandEigen { get; set; }

    public string? CHan { get; set; }

    public int NTeilbar { get; set; }

    public decimal FAufEinkaufslisteGesetzt { get; set; }

    public string? WarenlagerName { get; set; }

    public decimal? BestellmengeGesamt { get; set; }

    public long KArtikelEinkaufsliste { get; set; }

    public int? KWarenLager { get; set; }

    public int? NStandardLager { get; set; }
}
