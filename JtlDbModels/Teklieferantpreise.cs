using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Teklieferantpreise
{
    public int KEklieferantPreise { get; set; }

    public int? KArtikel { get; set; }

    public int? KLieferant { get; set; }

    public int? NAnzahl1 { get; set; }

    public int? NAnzahl2 { get; set; }

    public int? NAnzahl3 { get; set; }

    public int? NAnzahl4 { get; set; }

    public int? NAnzahl5 { get; set; }

    public decimal FPreis1 { get; set; }

    public decimal FPreis2 { get; set; }

    public decimal FPreis3 { get; set; }

    public decimal FPreis4 { get; set; }

    public decimal FPreis5 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
