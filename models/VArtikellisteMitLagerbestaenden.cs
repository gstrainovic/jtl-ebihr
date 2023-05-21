using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikellisteMitLagerbestaenden
{
    public int KArtikel { get; set; }

    public int KStueckliste { get; set; }

    public int KVaterArtikel { get; set; }

    public int KArtikelForKategorieArtikel { get; set; }

    public string Artikelnummer { get; set; } = null!;

    public int Sortiernummer { get; set; }

    public string? Artikelname { get; set; }

    public string? Einheit { get; set; }

    public string? Ean { get; set; }

    public string? Herkunftsland { get; set; }

    public string? Unnummer { get; set; }

    public string? CHan { get; set; }

    public string? Gefahrennummer { get; set; }

    public string? Isbn { get; set; }

    public string? Asin { get; set; }

    public string? TaricCode { get; set; }

    public string? Upc { get; set; }

    public string? Hersteller { get; set; }

    public string? Lieferstatus { get; set; }

    public decimal Breite { get; set; }

    public decimal Hoehe { get; set; }

    public decimal Laenge { get; set; }

    public DateTime? Erstelldatum { get; set; }

    public DateTime? Bearbeitungsdatum { get; set; }

    public string? Bearbeiter { get; set; }

    public decimal EinkaufspreisDurchschnittNetto { get; set; }

    public decimal EinkaufspreisLetzerEinkauf { get; set; }

    public DateTime? DatumLetzerEinkauf { get; set; }

    public decimal VerkaufspreisNetto { get; set; }

    public string? Labels { get; set; }

    public decimal Uvp { get; set; }

    public decimal? Gewinn { get; set; }

    public int Zustand { get; set; }

    public string ZustandName { get; set; } = null!;

    public decimal? GewinnInProzent { get; set; }

    public decimal PreisAmazon { get; set; }

    public decimal PreisEbay { get; set; }

    public int Sonderpreis { get; set; }

    public decimal? GrundpreisWert { get; set; }

    public string? Grundpreiseinheit { get; set; }

    public string? Masseinheit { get; set; }

    public decimal Versandgewicht { get; set; }

    public decimal Gewicht { get; set; }

    public decimal BestandGesamt { get; set; }

    public decimal BestandEigen { get; set; }

    public decimal BestandImZulauf { get; set; }

    public decimal BestandAufEinkaufsliste { get; set; }

    public decimal BestandInAuftraegen { get; set; }

    public decimal BestandVerfuegbar { get; set; }

    public decimal MindestAbnahmemenge { get; set; }

    public decimal Abnahmeintervall { get; set; }

    public int BestandInAmazonAngeboten { get; set; }

    public string CLagerfuehrungaktiv { get; set; } = null!;

    public string CIstAufPreisliste { get; set; } = null!;

    public string CIstAktiv { get; set; } = null!;

    public string? CIstTopArtikel { get; set; }

    public string CIstNeu { get; set; } = null!;

    public bool? IstStueckliste { get; set; }

    public bool? IstStuecklistenkomponente { get; set; }

    public string? CIstSeriennummer { get; set; }

    public string? CIstStueckzahlteilbar { get; set; }

    public string CIstUeberverkaufMoeglich { get; set; } = null!;

    public byte NIstVarkombiVater { get; set; }

    public int NIstVarkombikind { get; set; }

    public byte? NHatMindestbestand { get; set; }

    public byte NIstMhd { get; set; }

    public byte NIstCharge { get; set; }

    public byte NIstFuerBestellvorschlagGesperrt { get; set; }

    public int NShopAktiv { get; set; }

    public byte? NVpe { get; set; }

    public decimal? EbayBestand { get; set; }

    public decimal? VerkaufspreisBrutto { get; set; }

    public string? Anmerkung { get; set; }

    public string? Lieferant { get; set; }

    public byte? NBeschaffungszeitAutomatisch { get; set; }

    public int? BeschaffungszeitManuell { get; set; }

    public string? Beschreibung { get; set; }

    public DateTime? ErscheintAm { get; set; }

    public string? Kurzbeschreibung { get; set; }

    public byte KeinBestellvorgang { get; set; }

    public string? Serie { get; set; }

    public string? Steuerklasse { get; set; }

    public string? Warengruppe { get; set; }

    public int? ZusaetzlicheBearbeitungszeit { get; set; }

    public string? Versandklasse { get; set; }

    public string? Jtlfpid { get; set; }

    public bool? FfnAktiv { get; set; }

    public bool? FfnEigen { get; set; }

    public int ZustandSprache { get; set; }

    public decimal ReserviertGesamt { get; set; }

    public string? AmazonFnsku { get; set; }

    public int Puffer { get; set; }

    public byte NSeriennummernVerfolgung { get; set; }

    public string? MetaDescription { get; set; }

    public string? TitleTag { get; set; }

    public string? MetaKeywords { get; set; }

    public decimal NMidestbestand { get; set; }

    public int KFirma { get; set; }

    public int Startlager { get; set; }

    public decimal? Startlagerbestand { get; set; }

    public int Ziellager { get; set; }

    public decimal? Ziellagerbestand { get; set; }
}
