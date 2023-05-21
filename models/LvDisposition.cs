using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvDisposition
{
    public int KArtikel { get; set; }

    public int KDisposition { get; set; }

    public string? CComment { get; set; }

    public string? BenutzerNameDispo { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset? DIntendedCompletionDate { get; set; }

    public byte NReferenceType { get; set; }

    public decimal FQuantity { get; set; }

    public decimal FActualQuantity { get; set; }

    public decimal FPlannedQuantity { get; set; }

    public byte NStatus { get; set; }

    public string? ReferenceFieldIssue { get; set; }

    public string? ReferenceFieldIssuePosition { get; set; }

    public string Artikelnummer { get; set; } = null!;

    public int Sortiernummer { get; set; }

    public string? Artikelname { get; set; }

    public string? Einheit { get; set; }

    public string? Ean { get; set; }

    public string? CHan { get; set; }

    public decimal Breite { get; set; }

    public decimal Hoehe { get; set; }

    public decimal Laenge { get; set; }

    public DateTimeOffset Erstelldatum { get; set; }

    public DateTimeOffset Bearbeitungsdatum { get; set; }

    public string? Bearbeiter { get; set; }

    public string? Labels { get; set; }

    public string? Masseinheit { get; set; }

    public decimal Versandgewicht { get; set; }

    public decimal Gewicht { get; set; }

    public decimal BestandGesamt { get; set; }

    public decimal BestandEigen { get; set; }

    public decimal BestandImZulauf { get; set; }

    public decimal BestandAufEinkaufsliste { get; set; }

    public decimal BestandInAuftraegen { get; set; }

    public decimal BestandVerfuegbar { get; set; }

    public decimal Produzierbar { get; set; }

    public decimal? InProduktion { get; set; }

    public decimal? Mindestbestand { get; set; }

    public bool? IstLagerfuehrungaktiv { get; set; }

    public bool? IstAktiv { get; set; }

    public bool? IstSeriennummer { get; set; }

    public bool? IstStueckzahlteilbar { get; set; }

    public bool? IstUeberverkaufMoeglich { get; set; }

    public bool? IstVarkombikind { get; set; }

    public bool? HatMindestbestand { get; set; }

    public bool? IstMhd { get; set; }

    public bool? IstCharge { get; set; }

    public bool? IstFuerBestellvorschlagGesperrt { get; set; }

    public bool? TeilmengenArtikel { get; set; }

    public string? Warengruppe { get; set; }

    public int ZustandSprache { get; set; }

    public string ZustandName { get; set; } = null!;

    public int Puffer { get; set; }

    public bool? SeriennummernVerfolgung { get; set; }

    public DateTime? DFilterDate { get; set; }

    public decimal FQuantityInProductionOrders { get; set; }

    public int KSprache { get; set; }

    public string? CNameEng { get; set; }

    public string? CNameDeu { get; set; }

    public string? CIso { get; set; }

    public byte? NStandard { get; set; }

    public string? CKultur { get; set; }

    public string CIso2 { get; set; } = null!;
}
