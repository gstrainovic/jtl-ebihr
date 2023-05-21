using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRetouren
{
    public int KBestellung { get; set; }

    public int KArtikel { get; set; }

    public int? KAmazonBestellung { get; set; }

    public int KAmazonRetourPos { get; set; }

    public int KUser { get; set; }

    public string? COrderId { get; set; }

    public string? CBestellNr { get; set; }

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

    public int NGutschriftStatus { get; set; }

    public DateTime? DEingelesen { get; set; }

    public string? CLicencePlateNumber { get; set; }

    public DateTime? DVersandt { get; set; }

    public string? KundenName { get; set; }

    public string? MarkteplaceName { get; set; }

    public decimal? FAmountPerItem { get; set; }

    public decimal FAuftragsWertBrutto { get; set; }

    public int NHasRechnung { get; set; }

    public decimal? FGutschrift { get; set; }

    public string? CFehler { get; set; }

    public string? COrderItemCode { get; set; }

    public string? CFulfillmentId { get; set; }

    public int NIsVcs { get; set; }

    public int NIsAmazonInvoice { get; set; }

    public string? CShipCountry { get; set; }
}
