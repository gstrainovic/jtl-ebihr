using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VDisposition
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

    public decimal Produzierbar { get; set; }

    public decimal? InProduktion { get; set; }

    public decimal FQuantityInProductionOrders { get; set; }

    public decimal FActualQuantityWithProductionOrder { get; set; }

    public decimal FPlannedQuantityWithProductionOrder { get; set; }

    public decimal FActualQuantityInProductionOrders { get; set; }

    public byte NStatus { get; set; }

    public string? ReferenceFieldIssue { get; set; }

    public string? ReferenceFieldIssuePosition { get; set; }

    public int? KReferenceField { get; set; }

    public DateTimeOffset? DIssueDate { get; set; }

    public string Artikelnummer { get; set; } = null!;

    public int Sortiernummer { get; set; }

    public string? Artikelname { get; set; }

    public DateTimeOffset Erstelldatum { get; set; }

    public DateTimeOffset Bearbeitungsdatum { get; set; }

    public int? KBenutzerLastChange { get; set; }

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

    public bool? SeriennummernVerfolgung { get; set; }

    public int KSprache { get; set; }
}
