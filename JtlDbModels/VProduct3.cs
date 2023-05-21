using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VProduct3
{
    public int KProduct { get; set; }

    public string CSku { get; set; } = null!;

    public string? CTitle { get; set; }

    public string? CSubTitle { get; set; }

    public string? CDescription { get; set; }

    public string? CGtin { get; set; }

    public string? CIsbn { get; set; }

    public int KShop { get; set; }

    public decimal? FQuantity { get; set; }

    public int KCategory { get; set; }

    public string? CScxCategoryId { get; set; }

    public decimal NMindestbestand { get; set; }

    public decimal NMaximalerBestand { get; set; }

    public decimal? FChannelQuantity { get; set; }

    public int NAktion { get; set; }

    public int KSteuerklasse { get; set; }

    public string? CMpn { get; set; }

    public string? CBrand { get; set; }

    public string? CShopTitle { get; set; }

    public string? CShopSubTitle { get; set; }

    public string? CShopDescription { get; set; }

    public decimal FSrpAmount { get; set; }

    public string? CSrpCurrency { get; set; }

    public bool NIsParent { get; set; }

    public int KParent { get; set; }

    public bool NVariationsSupported { get; set; }
}
