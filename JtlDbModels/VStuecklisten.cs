using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStuecklisten
{
    public string CArtNr { get; set; } = null!;

    public string? Einkaufspreis { get; set; }

    public string? Artikelgewicht { get; set; }

    public string? Versandgewicht { get; set; }

    public string? Lagerführung { get; set; }

    public string? Überverkäufe { get; set; }

    public string? Teilbarkeit { get; set; }

    public string? Lieferzeitberechnung { get; set; }

    public string? Bearbeitungszeit { get; set; }

    public int KArtikel { get; set; }
}
