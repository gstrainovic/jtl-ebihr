using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAbrechnungPositionen
{
    public int KAbrechnungPos { get; set; }

    public int KAbrechnung { get; set; }

    public int KArtikel { get; set; }

    public decimal FAnzahl { get; set; }

    public string? CEinheit { get; set; }

    public string? CArtikelnummer { get; set; }

    public string? CBezeichnung { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal FMwSt { get; set; }

    public decimal FVkBrutto { get; set; }

    public decimal FRabatt { get; set; }

    public decimal? FVkBruttoGesamt { get; set; }

    public decimal? FVkNettoGesamt { get; set; }

    public int NSort { get; set; }

    public string? CHinweis { get; set; }
}
