using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvItemStockDemand
{
    public int KItemStockDemand { get; set; }

    public Guid? IContext { get; set; }

    public int? KContext { get; set; }

    public int? KWarenLager { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public int? KWarenLagerBereich { get; set; }

    public int KArtikel { get; set; }

    public decimal FQuantity { get; set; }

    public int KBenutzer { get; set; }

    public string CComment { get; set; } = null!;

    public DateTimeOffset DCreationDate { get; set; }

    public DateTime? DFilterDate { get; set; }

    public DateTimeOffset? DTargetDate { get; set; }

    public byte NStatus { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public int? NSort { get; set; }

    public bool? IstMhd { get; set; }

    public bool? IstCharge { get; set; }

    public bool? IstSeriennummer { get; set; }

    public bool? IstStueckzahlteilbar { get; set; }

    public bool? TeilmengenArtikel { get; set; }

    public bool? SeriennummernVerfolgung { get; set; }

    public bool? IstUeberverkaufMoeglich { get; set; }

    public decimal? Mindestbestand { get; set; }

    public string? CHan { get; set; }

    public decimal Breite { get; set; }

    public decimal Hoehe { get; set; }

    public decimal Laenge { get; set; }

    public string? Gtin { get; set; }

    public decimal Versandgewicht { get; set; }

    public decimal Gewicht { get; set; }

    public decimal BestandGesamt { get; set; }

    public decimal BestandEigen { get; set; }

    public decimal BestandImZulauf { get; set; }

    public decimal BestandAufEinkaufsliste { get; set; }

    public decimal BestandInAuftraegen { get; set; }

    public decimal BestandVerfuegbar { get; set; }

    public string? BenutzerNameDemand { get; set; }

    public decimal Produzierbar { get; set; }

    public decimal InProduktion { get; set; }
}
