using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKundenGruppeShop
{
    public int? KKunde { get; set; }

    public int KKundenGruppe { get; set; }

    public int KInetKunde { get; set; }

    public string? ShopName { get; set; }

    public string? Kundengruppe { get; set; }

    public string? DKundeSeit { get; set; }

    public short? NRegistriert { get; set; }

    public string? CShopKundenNr { get; set; }

    public int KShop { get; set; }

    public int? KGutschein { get; set; }

    public decimal? FWert { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? GutscheinGrund { get; set; }
}
