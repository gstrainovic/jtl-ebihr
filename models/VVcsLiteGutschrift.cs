using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VVcsLiteGutschrift
{
    public int KVcsdata { get; set; }

    public int KUser { get; set; }

    public string OrderId { get; set; } = null!;

    public string? OrderItemId { get; set; }

    public string? Sku { get; set; }

    public string? ProductName { get; set; }

    public string? Asin { get; set; }

    public decimal? QuantityPurchased { get; set; }

    public string? ShippingId { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionType { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ShippingDate { get; set; }

    public string? Currency { get; set; }

    public decimal? ItemVatInclAmount { get; set; }

    public decimal? ItemVatAmount { get; set; }

    public decimal? ItemVatExclAmount { get; set; }

    public decimal? ItemVatRate { get; set; }

    public decimal? ItemPromoVatInclAmount { get; set; }

    public decimal? ItemPromoVatAmount { get; set; }

    public decimal? ItemPromoVatExclAmount { get; set; }

    public decimal? ItemPromoVatRate { get; set; }

    public decimal? ShippingVatInclAmount { get; set; }

    public decimal? ShippingVatAmount { get; set; }

    public decimal? ShippingVatExclAmount { get; set; }

    public decimal? ShippingVatRate { get; set; }

    public decimal? ShippingPromoVatInclAmount { get; set; }

    public decimal? ShippingPromoVatAmount { get; set; }

    public decimal? ShippingPromoVatExclAmount { get; set; }

    public decimal? ShippingPromoVatRate { get; set; }

    public decimal? GiftWrapVatInclAmount { get; set; }

    public decimal? GiftWrapVatAmount { get; set; }

    public decimal? GiftWrapVatExclAmount { get; set; }

    public decimal? GiftWrapVatRate { get; set; }

    public decimal? GiftPromoVatInclAmount { get; set; }

    public decimal? GiftPromoVatExclAmount { get; set; }

    public decimal? GiftPromoVatAmount { get; set; }

    public decimal? GiftPromoVatRate { get; set; }

    public string? ItemPromotionId { get; set; }

    public string? ShipPromotionId { get; set; }

    public string? GiftPromotionId { get; set; }

    public string? BuyerVatNumber { get; set; }

    public string? SellerVatNumber { get; set; }

    public string? IsBusinessOrder { get; set; }

    public string? PriceDesignation { get; set; }

    public string? MarketplaceId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? RecipientName { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerCompanyName { get; set; }

    public string? ShipServiceLevel { get; set; }

    public string? ShipAddress1 { get; set; }

    public string? ShipAddress2 { get; set; }

    public string? ShipAddress3 { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipState { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }

    public string? ShipPhoneNumber { get; set; }

    public string? BillingName { get; set; }

    public string? BillAddress1 { get; set; }

    public string? BillAddress2 { get; set; }

    public string? BillAddress3 { get; set; }

    public string? BillCity { get; set; }

    public string? BillState { get; set; }

    public string? BillPostalCode { get; set; }

    public string? BillCountry { get; set; }

    public string? BillingPhoneNumber { get; set; }

    public string? ShipFromCity { get; set; }

    public string? ShipFromState { get; set; }

    public string? ShipFromCountry { get; set; }

    public string? ShipFromPostalCode { get; set; }

    public string? FulfilledBy { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? InvoiceStatus { get; set; }

    public string? InvoiceStatusDescription { get; set; }

    public string? LegacyCustomerOrderItemId { get; set; }

    public string? RecommendedInvoiceFormat { get; set; }

    public int? KBestellPos { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? KGutschriftPos { get; set; }

    public int NUploadVersuche { get; set; }

    public string? CWawiRechnungsnummer { get; set; }

    public string? CWawiRechnungskorrekturnummer { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsInvoiceCorrected { get; set; }

    public string? OriginalVatinvoiceNumber { get; set; }

    public string? InvoiceCorrectionDetails { get; set; }

    public string? BuyerTaxRegistrationType { get; set; }

    public string? BuyerEinvoiceAccountId { get; set; }

    public bool IsBuyerPhysicallyPresent { get; set; }

    public bool IsSellerPhysicallyPresent { get; set; }

    public string? CitationEs { get; set; }

    public string? CitationIt { get; set; }

    public string? CitationFr { get; set; }

    public string? CitationDe { get; set; }

    public string? CitationEn { get; set; }

    public bool? ExportOutsideEu { get; set; }

    public bool NInProgress { get; set; }

    public bool NProcessed { get; set; }

    public int KRechnung { get; set; }

    public int KGutschrift { get; set; }

    public bool IsAmazonInvoiced { get; set; }

    public int? KArtikel { get; set; }

    public string? CArtikelnummer { get; set; }

    public decimal FEknetto { get; set; }

    public decimal FArtGewicht { get; set; }

    public decimal FGewicht { get; set; }

    public string? CEinheit { get; set; }

    public byte NVcsHerkunftsTyp { get; set; }

    public int KVcsRechnung { get; set; }

    public byte NVcsRechnungsherkunftsTyp { get; set; }

    public int DuplicateInvoiceId { get; set; }

    public int DuplicateInvoiceCorrectionId { get; set; }
}
