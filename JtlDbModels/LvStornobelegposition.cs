using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvStornobelegposition
{
    public int KStornobeleg { get; set; }

    public int KStornobelegPos { get; set; }

    public int? KAuftragPosition { get; set; }

    public int KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CArtNr { get; set; }

    public decimal? FAnzahl { get; set; }

    public decimal? FVknetto { get; set; }

    public decimal? FMwSt { get; set; }

    public decimal? FVkbrutto { get; set; }

    public int KStuecklistenVater { get; set; }

    public int? KKonfigurationsVater { get; set; }

    public int? KAuftrag { get; set; }

    public int? KShop { get; set; }

    public string? CShopname { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public string? CeBayBenutzername { get; set; }

    public int NSort { get; set; }

    public int? KRechnungPosition { get; set; }
}
