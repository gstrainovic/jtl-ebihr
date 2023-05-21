using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAmazonBestellungen
{
    public string? COrderId { get; set; }

    public string? CBuyerName { get; set; }

    public string? CBuyerEmail { get; set; }

    public string? CBuyerPhonenumber { get; set; }

    public string? CBuyerCompanyName { get; set; }

    public string? CBuyerTaxRegistrationId { get; set; }

    public string? CBuyerCstNumber { get; set; }

    public DateTime? DEarliestShipAt { get; set; }

    public DateTime? DLatestShipAt { get; set; }

    public DateTime? DEarliestDeliveryAt { get; set; }

    public DateTime? DLatestDeliveryAt { get; set; }

    public string? CShipServiceName { get; set; }

    public string? CPaymentMethod { get; set; }

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

    public string? CShipPostalcode { get; set; }

    public string? CShipCountry { get; set; }

    public string? CShipPhonenumber { get; set; }

    public string? CCurrency { get; set; }

    public string? CShipServicelevel { get; set; }

    public decimal FItemPromotionalDiscount { get; set; }

    public string? CItemPromotionId { get; set; }

    public string? CShipPromotionId { get; set; }

    public decimal FVersandkosten { get; set; }

    public DateTime? DPaymentsDate { get; set; }

    public DateTime? DPurchasedate { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? NAnzahlPos { get; set; }

    public decimal? FSumGesamtOfItemPrice { get; set; }

    public string? CUserName { get; set; }

    public int? NAnzahlArtikel { get; set; }

    public int NStatus { get; set; }

    public int NVersandStatus { get; set; }

    public string? CSalesChannel { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorMessage { get; set; }

    public byte? NFba { get; set; }

    public string CVersandlandIso { get; set; } = null!;

    public int KAmazonBestellung { get; set; }

    public int KUser { get; set; }

    public int NOrderStatus { get; set; }

    public byte? NIstGeschenk { get; set; }

    public byte? NIstCustom { get; set; }

    public string? COrderStatus { get; set; }

    public byte? NStornogrund { get; set; }

    public string CStornobenutzer { get; set; } = null!;

    public DateTime? DStornozeitpunkt { get; set; }

    public bool NB2b { get; set; }
}
