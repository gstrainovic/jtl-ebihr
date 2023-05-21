using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandKonfiguration
{
    public int KVersandKonfiguration { get; set; }

    public string? CName { get; set; }

    public byte? NArt { get; set; }

    public int? NAnzahl { get; set; }

    public byte? NAnzahlProPaket { get; set; }

    public int? KFormular { get; set; }

    public string? CText { get; set; }

    public byte? NLandTyp { get; set; }

    public string? CLaenderListeIso { get; set; }

    public decimal FWertVon { get; set; }

    public decimal FWertBis { get; set; }

    public int? KWarenlager { get; set; }

    public string? CVersandartListe { get; set; }

    public decimal FGewichtMax { get; set; }

    public decimal FGewichtMin { get; set; }

    public string? CFirmen { get; set; }

    public string? CKundengruppen { get; set; }

    public string? CVersandklassen { get; set; }

    public string? CZahlungsarten { get; set; }

    public string? CWarengruppen { get; set; }

    public string? CPlattformen { get; set; }

    public string? CShops { get; set; }

    public byte NEnthaeltArtAusWarengruppe { get; set; }

    public byte NAlleOhneWarengruppe { get; set; }

    public byte NAlleOhneVersandart { get; set; }

    public byte NAlleOhneZahlungsart { get; set; }

    public string? CBenutzer { get; set; }

    public byte NAuftragsArt { get; set; }

    public int? NVorgang { get; set; }

    public byte? NAusfuehrungBei { get; set; }

    public byte? NDiffAdressRechnungLieferschein { get; set; }

    public int NArtikelBreiteVon { get; set; }

    public int NArtikelBreiteBis { get; set; }

    public int NArtikelHoeheVon { get; set; }

    public int NArtikelHoeheBis { get; set; }

    public int NArtikelLaengeVon { get; set; }

    public int NArtikelLaengeBis { get; set; }

    public byte NEigeneFelderFilter { get; set; }

    public byte NArtikelZustandFilter { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
