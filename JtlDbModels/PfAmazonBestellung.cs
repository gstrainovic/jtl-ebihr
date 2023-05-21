using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonBestellung
{
    public int KAmazonBestellung { get; set; }

    public long KMessageId { get; set; }

    public int KUser { get; set; }

    public string? COrderId { get; set; }

    public string? CBuyerName { get; set; }

    public string? CBuyerEmail { get; set; }

    public string? CBuyerPhoneNumber { get; set; }

    public string? CBillAddress1 { get; set; }

    public string? CBillAddress2 { get; set; }

    public string? CBillAddress3 { get; set; }

    public string? CBillCity { get; set; }

    public string? CBillState { get; set; }

    public string? CBillPostalCode { get; set; }

    public string? CBillCountry { get; set; }

    public string? CRecipientName { get; set; }

    public string? CShipAddress1 { get; set; }

    public string? CShipAddress2 { get; set; }

    public string? CShipAddress3 { get; set; }

    public string? CShipCity { get; set; }

    public string? CShipState { get; set; }

    public string? CShipPostalCode { get; set; }

    public string? CShipCountry { get; set; }

    public string? CShipPhoneNumber { get; set; }

    public string? CCurrency { get; set; }

    public string? CShipServiceLevel { get; set; }

    public decimal FItemPromotionDiscount { get; set; }

    public string? CItemPromotionId { get; set; }

    public decimal FShipPromotionDiscount { get; set; }

    public string? CShipPromotionId { get; set; }

    public decimal FVersandkosten { get; set; }

    public DateTime? DPaymentsDate { get; set; }

    public DateTime? DPurchaseDate { get; set; }

    public DateTime? DErstellt { get; set; }

    public int NStatus { get; set; }

    public byte? NDeleted { get; set; }

    public string? CSalesChannel { get; set; }

    public DateTime? DShipmentDate { get; set; }

    public string? CMerchantOrderId { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorMessage { get; set; }

    public DateTime? DErrorErstellt { get; set; }

    public byte? NFba { get; set; }

    public int? KFulfillmentAuftrag { get; set; }

    public string? COrderStatus { get; set; }

    public string CVersandlandIso { get; set; } = null!;

    public byte NPrime { get; set; }

    public string? CKundenauftragsnummer { get; set; }

    public bool NIsAmazonInvoice { get; set; }

    public bool NB2b { get; set; }

    public string? CBuyerCompanyName { get; set; }

    public string? CBuyerTaxRegistrationId { get; set; }

    public string? CBuyerCstNumber { get; set; }

    public DateTime? DEarliestShipAt { get; set; }

    public DateTime? DLatestShipAt { get; set; }

    public DateTime? DEarliestDeliveryAt { get; set; }

    public DateTime? DLatestDeliveryAt { get; set; }

    public string? CShipServiceName { get; set; }

    public string? CPaymentMethod { get; set; }

    public string? CMarketplaceId { get; set; }

    public string COriginalOrderId { get; set; } = null!;

    public bool NIsMultichannelOrder { get; set; }
}
