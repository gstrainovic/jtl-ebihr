using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvEbayTransaction
{
    public string? CTitle { get; set; }

    public string? CSku { get; set; }

    public int? NQuantityPurchased { get; set; }

    public decimal FAmountPaid { get; set; }

    public string? CZusatzoptionen { get; set; }

    public string? CEbayBuyerName { get; set; }

    public string? CUserId { get; set; }

    public DateTime? DCreateDate { get; set; }

    public DateTime? DCheckoutErstelltAm { get; set; }

    public DateTime? DAbgeschlossenAm { get; set; }

    public string? CBezahltOffen { get; set; }

    public DateTime? DBezahltAbgeschlossen { get; set; }

    public string? CPlattform { get; set; }

    public string? CEbayUserName { get; set; }

    public byte? NKonflikt { get; set; }

    public string? CStreet { get; set; }

    public string? CStreet1 { get; set; }

    public string? CStreet2 { get; set; }

    public string? CCityName { get; set; }

    public string? CPostalCode { get; set; }

    public string? CCountryName { get; set; }

    public string? CSaName { get; set; }

    public string? CSaStreet { get; set; }

    public string? CSaStreet1 { get; set; }

    public string? CSaStreet2 { get; set; }

    public string? CSaCityName { get; set; }

    public string? CSaStateOrProvince { get; set; }

    public string? CSaPostalCode { get; set; }

    public string? CSaCountryname { get; set; }

    public string? CEmail { get; set; }

    public string? CTransactionId { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public string? CItemId { get; set; }

    public int? KEbayItem { get; set; }

    public decimal? FSteuersatz { get; set; }

    public string? CZahlungsart { get; set; }

    public string? CPaymentStatus { get; set; }

    public string? CVerwendungszweck { get; set; }

    public int? KArtikel { get; set; }

    public int? KEbayUser { get; set; }

    public byte? NVariationenAktiv { get; set; }

    public int KTransaction { get; set; }

    public int? KBuyer { get; set; }

    public byte? NCheckOut { get; set; }

    public int? KEbayTemplate { get; set; }

    public int? NQuantity { get; set; }

    public int NSiteId { get; set; }

    public string? CCommentTextIn { get; set; }

    public string? CCommentTypeIn { get; set; }

    public string? CArtikelnummer { get; set; }

    public string? CDispute { get; set; }

    public byte? NKomplettAusgeliefert { get; set; }

    public byte? NTransactionStatus { get; set; }

    public string? CBestellNr { get; set; }

    public DateTime? DVersendet { get; set; }

    public int? KBestellung { get; set; }

    public string? CRelistId { get; set; }

    public byte? NEbayItemStatus { get; set; }

    public string? CEbayItemType { get; set; }

    public int? NListingType { get; set; }

    public byte? NPremium { get; set; }

    public int? NGalleryType { get; set; }

    public decimal FTransactionPrice { get; set; }

    public string? CVariationTitle { get; set; }

    public decimal FSssShippingServiceCost { get; set; }

    public decimal FSssShippingServiceAdditionalCost { get; set; }

    public string? CSssShippingService { get; set; }

    public int? KEigenschaftKombi { get; set; }

    public int? NVersandZahlungStatus { get; set; }
}
