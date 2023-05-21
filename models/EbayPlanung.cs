using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayPlanung
{
    public int KPlanung { get; set; }

    public int? KItem { get; set; }

    public int? KEbayUser { get; set; }

    public string? CPlanungsname { get; set; }

    public byte? CMo { get; set; }

    public byte? CDi { get; set; }

    public byte? CMi { get; set; }

    public byte? CDo { get; set; }

    public byte? CFr { get; set; }

    public byte? CSa { get; set; }

    public byte? CSo { get; set; }

    public string? CZeit1 { get; set; }

    public string? CZeit2 { get; set; }

    public string? CZeit3 { get; set; }

    public string? CZeit4 { get; set; }

    public string? CZeit5 { get; set; }

    public string? CZeit6 { get; set; }

    public DateTime? DPlanungsbeginn { get; set; }

    public DateTime? DPlanungsende { get; set; }

    public string? CStatus { get; set; }

    public int? NAlleXtage { get; set; }

    public string? CAlleXuhrzeit { get; set; }
}
