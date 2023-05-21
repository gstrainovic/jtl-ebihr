using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonRetourpo
{
    public int KAmazonRetourPos { get; set; }

    public int KUser { get; set; }

    public int? KAmazonBestellung { get; set; }

    public string? COrderId { get; set; }

    public string? CSellerSku { get; set; }

    public string? CFremdSku { get; set; }

    public string? CAsin { get; set; }

    public string? CArtikelname { get; set; }

    public int NMenge { get; set; }

    public string? CFulfillmentCenter { get; set; }

    public string? CArtikelzustand { get; set; }

    public string? CRueckgabegrund { get; set; }

    public DateTime? DRetourzeit { get; set; }

    public byte? NStatus { get; set; }

    public DateTime? DEingelesen { get; set; }

    public long? KMessageId { get; set; }

    public string? CFehler { get; set; }

    public string? CLicencePlateNumber { get; set; }

    public string? CKundenkommentar { get; set; }

    public long KSettlementPos { get; set; }

    public int NGutschriftStatus { get; set; }

    public decimal? FAmountPerItem { get; set; }

    public string? COrderItemCode { get; set; }

    public string? CFulfillmentId { get; set; }
}
