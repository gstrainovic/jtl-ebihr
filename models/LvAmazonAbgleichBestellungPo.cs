using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAmazonAbgleichBestellungPo
{
    public int KAmazonBestellung { get; set; }

    public int KAmazonBestellungPos { get; set; }

    public string? CArtNr { get; set; }

    public string? CArtikelname { get; set; }

    public decimal FItemPrice { get; set; }

    public int NQuantityPurchased { get; set; }

    public DateTime? DShipdate { get; set; }
}
