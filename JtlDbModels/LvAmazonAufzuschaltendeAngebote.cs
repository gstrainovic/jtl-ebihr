using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAmazonAufzuschaltendeAngebote
{
    public string? KAmazonAngebotNeu { get; set; }

    public string CSellerSku { get; set; } = null!;

    public string? CName { get; set; }

    public int? NQuantity { get; set; }

    public decimal FPrice { get; set; }

    public byte? NCondition { get; set; }

    public string? CAsin { get; set; }

    public string? CEan { get; set; }

    public string? CIsbn { get; set; }

    public string? CUpc { get; set; }

    public int KUser { get; set; }

    public string? CPfUsername { get; set; }

    public string? CWaehrung { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public byte? NStatus { get; set; }

    public string? CLetzerFehler { get; set; }

    public int NPlattform { get; set; }

    public string? CConditionnote { get; set; }

    public byte? NProductIdType { get; set; }

    public byte? NFulfillmentChannel { get; set; }

    public string? CAmazonVersandgruppe { get; set; }

    public int? ArtikelId { get; set; }

    public string? CArtikelName { get; set; }

    public string? CHan { get; set; }

    public string? CArtikelnummerWawi { get; set; }
}
