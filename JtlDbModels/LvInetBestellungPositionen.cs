using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvInetBestellungPositionen
{
    public int KInetBestellPos { get; set; }

    public int? KInetBestellung { get; set; }

    public string? CArtNr { get; set; }

    public int? KArikel { get; set; }

    public decimal FPreis { get; set; }

    public decimal FMwSt { get; set; }

    public decimal NAnzahl { get; set; }

    public string? CName { get; set; }

    public int KShop { get; set; }

    public byte? NType { get; set; }

    public string? CHinweis { get; set; }

    public string? CEinheit { get; set; }
}
