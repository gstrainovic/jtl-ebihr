using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAmazonAbgleichAngebote
{
    public string? KAmazonAngebot { get; set; }

    public int KUser { get; set; }

    public string? CItemname { get; set; }

    public string CSellerSku { get; set; } = null!;

    public string? CArtNr { get; set; }

    public string? CName { get; set; }

    public int? NPlattform { get; set; }

    public string? CAsin1 { get; set; }

    public decimal FPrice { get; set; }

    public decimal? FPreis { get; set; }

    public string? CWaehrung { get; set; }

    public int? NQuantity { get; set; }

    public int? NMaxBestand { get; set; }

    public string CKommentar { get; set; } = null!;

    public decimal? FVersandkosten { get; set; }

    public string? CEan { get; set; }

    public string? CIsbn { get; set; }

    public string? CUpc { get; set; }

    public string? CArtikelName { get; set; }

    public byte NWirdAusSortimentEntfernt { get; set; }

    public int NPreisBestandsAnpassung { get; set; }
}
