using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class V360GradSicht
{
    public int KKunde { get; set; }

    public string? CKundenNr { get; set; }

    public string? CAnrede { get; set; }

    public string? CTitel { get; set; }

    public string? KundenGruppe { get; set; }

    public string? KundenKategorie { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public string? CFirma { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CTel { get; set; }

    public string? CMobil { get; set; }

    public string? CFax { get; set; }

    public string? CMail { get; set; }

    public string? CGeburtstag { get; set; }

    public string? StandartZahlungsart { get; set; }

    public bool? Gesperrt { get; set; }

    public bool? Newsletter { get; set; }

    public bool? Mahnstopp { get; set; }

    public bool? HerkunftAmazon { get; set; }

    public bool? HerkunftEbay { get; set; }

    public bool? KasseKunde { get; set; }

    public bool? ShopKunde { get; set; }

    public bool? KundenvindividuellePreise { get; set; }

    public DateTime? KundeSeit { get; set; }

    public DateTime? LetzteBestellung { get; set; }

    public decimal? Umsatz { get; set; }

    public decimal AvgWarenkorb { get; set; }

    public int AnzahlBestellungen { get; set; }

    public int AnzahlStorno { get; set; }

    public int AnzahlOffen { get; set; }

    public int AnzahlMahnungen { get; set; }

    public int OffeneRechnungen { get; set; }

    public decimal RabattKunde { get; set; }

    public int AnzahlRetouren { get; set; }

    public decimal Kundenguthaben { get; set; }

    public int MitCoupon { get; set; }

    public decimal? Gewinn { get; set; }

    public decimal SummeBestellungOffen { get; set; }

    public decimal SummeRechnungOffen { get; set; }
}
