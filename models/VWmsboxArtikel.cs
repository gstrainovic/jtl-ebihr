using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VWmsboxArtikel
{
    public int KArtikel { get; set; }

    public int KLhm { get; set; }

    public string? CLhmid { get; set; }

    public int? KWarenlagerPlatz { get; set; }

    public string? CBestellNr { get; set; }

    public int? KBestellung { get; set; }

    public int? KBestellungDerLhm { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public string? CBarcode { get; set; }

    public int? KLhmstatus { get; set; }

    public decimal FAnzahlGes { get; set; }

    public decimal? FAnzahlInBox { get; set; }

    public decimal? FAnzahlAuftrag { get; set; }

    public byte NSperre { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DBezahlt { get; set; }

    public string? CStrasse { get; set; }

    public string? COrt { get; set; }

    public string? CPlz { get; set; }

    public string? CLand { get; set; }

    public string? CVersName { get; set; }

    public string? CLogistikName { get; set; }

    public string? CEinheit { get; set; }
}
