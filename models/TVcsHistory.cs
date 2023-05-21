using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVcsHistory
{
    public long KMessageId { get; set; }

    public int KUser { get; set; }

    public string? MarketplaceId { get; set; }

    public string? MerchantId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? TransactionType { get; set; }

    public string? OrderId { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? ShipmentId { get; set; }

    public string? TransactionId { get; set; }

    public string? Asin { get; set; }

    public string? Sku { get; set; }

    public int? Quantity { get; set; }

    public DateTime? TaxCalculationDate { get; set; }

    public decimal? TaxRate { get; set; }

    public string? ProductTaxCode { get; set; }

    public string? Currency { get; set; }

    public string? TaxType { get; set; }

    public string? TaxCalculationReasonCode { get; set; }

    public string? TaxAddressRole { get; set; }

    public string? JurisdictionLevel { get; set; }

    public string? JurisdictionName { get; set; }

    public decimal? OurPricetaxInclusiveSellingPrice { get; set; }

    public decimal? OurPricetaxAmount { get; set; }

    public decimal? OurPricetaxExclusiveSellingPrice { get; set; }

    public decimal? OurPricetaxInclusivePromoAmount { get; set; }

    public decimal? OurPricetaxAmountPromo { get; set; }

    public decimal? OurPricetaxExclusivePromoAmount { get; set; }

    public decimal? ShippingtaxInclusiveSellingPrice { get; set; }

    public decimal? ShippingtaxAmount { get; set; }

    public decimal? ShippingtaxExclusiveSellingPrice { get; set; }

    public decimal? ShippingtaxInclusivePromoAmount { get; set; }

    public decimal? ShippingtaxAmountPromo { get; set; }

    public decimal? ShippingtaxExclusivePromoAmount { get; set; }

    public decimal? GiftwraptaxInclusiveSellingPrice { get; set; }

    public decimal? GiftwraptaxAmount { get; set; }

    public decimal? GiftwraptaxExclusiveSellingPrice { get; set; }

    public decimal? GiftwraptaxInclusivePromoAmount { get; set; }

    public decimal? GiftwraptaxAmountPromo { get; set; }

    public decimal? GiftwraptaxExclusivePromoAmount { get; set; }

    public string? SellerTaxRegistration { get; set; }

    public string? SellerTaxRegistrationJurisdiction { get; set; }

    public string? BuyerTaxRegistration { get; set; }

    public string? BuyerTaxRegistrationJurisdiction { get; set; }

    public string? InvoiceLevelCurrencyCode { get; set; }

    public decimal? InvoiceLevelExchangeRate { get; set; }

    public DateTime? InvoiceLevelExchangeRateDate { get; set; }

    public decimal? ConvertedTaxAmount { get; set; }

    public string? VatinvoiceNumber { get; set; }

    public string? InvoiceUrl { get; set; }

    public string? ExportOutsideEu { get; set; }

    public string? ShipFromCity { get; set; }

    public string? ShipFromState { get; set; }

    public string? ShipFromCountry { get; set; }

    public string? ShipFromPostalCode { get; set; }

    public string? ShipFromTaxLocationCode { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToState { get; set; }

    public string? ShipToCountry { get; set; }

    public string? ShipToPostalCode { get; set; }

    public string? ShipToLocationCode { get; set; }

    public string? ReturnFcCountry { get; set; }

    public string? TaxReportingScheme { get; set; }

    public bool IsInvoiceCorrected { get; set; }

    public string? OriginalVatinvoiceNumber { get; set; }

    public string? InvoiceCorrectionDetails { get; set; }

    public string? SdiinvoiceDeliveryStatus { get; set; }

    public string? SdiinvoiceErrorCode { get; set; }

    public string? SdiinvoiceErrorDescription { get; set; }

    public DateTime? SdiinvoiceStatusLastUpdatedDate { get; set; }

    public string? TaxCollectionResponsibility { get; set; }

    public string? BuyerTaxRegistrationType { get; set; }

    public string? BuyerEinvoiceAccountId { get; set; }

    public bool IsAmazonInvoiced { get; set; }

    public string? EinvoiceUrl { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public DateTime DAktualisiertUtc { get; set; }

    public DateTime? DStatusAktualisiertUtc { get; set; }

    public DateTime? DVerarbeitetUtc { get; set; }
}
