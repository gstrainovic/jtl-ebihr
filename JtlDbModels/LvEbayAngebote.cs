using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvEbayAngebote
{
    public string? CZahlunghinweis { get; set; }

    public string? CCountryName { get; set; }

    public string? CWaehrungIso { get; set; }

    public byte? NBestandReserviert { get; set; }

    public decimal FBestOfferAutoAcceptPrice { get; set; }

    public byte? NBestOfferEnabled { get; set; }

    public decimal FBestOfferMinPrice { get; set; }

    public decimal FBuyItNowPrice { get; set; }

    public string? CRelistId { get; set; }

    public string? CRueckgabefrist { get; set; }

    public string? CVersandkostenTraeger { get; set; }

    public byte? NDispatchTimeMax { get; set; }

    public decimal? FStreichPreis { get; set; }

    public decimal? FWawiPreisNetto { get; set; }

    public decimal? FWawiPreisBrutto { get; set; }

    public byte? NGetItFast { get; set; }

    public string? CItemId { get; set; }

    public int? KArtikel { get; set; }

    public int KEbayItem { get; set; }

    public int? KKategorie { get; set; }

    public int? KEbayVorlage { get; set; }

    public string? CListingDuration { get; set; }

    public string? CListingType { get; set; }

    public string? CLocation { get; set; }

    public int? NLotSize { get; set; }

    public int NMinQuantity { get; set; }

    public int NMaxQuantity { get; set; }

    public byte? NAutomatischEinstellen { get; set; }

    public byte? NEbayPlus { get; set; }

    public byte? NPremium { get; set; }

    public byte? NVariationenAktiv { get; set; }

    public string? CPaymentMethods { get; set; }

    public string? CPayPalEmailAddress { get; set; }

    public string? CPostalCode { get; set; }

    public int NQuantity { get; set; }

    public decimal FReservePrice { get; set; }

    public string? CShipToLocations { get; set; }

    public int NSiteId { get; set; }

    public int? NBidCount { get; set; }

    public int? NBidderCount { get; set; }

    public decimal FCurrentPrice { get; set; }

    public string? CHighBidderUserId { get; set; }

    public decimal FStartPrice { get; set; }

    public byte? NStatus { get; set; }

    public string? CSubTitle { get; set; }

    public string? CTemplateName { get; set; }

    public string? CTitle { get; set; }

    public int NGrundpreisAngabe { get; set; }

    public decimal FTotalFees { get; set; }

    public string? CType { get; set; }

    public decimal FVatPercent { get; set; }

    public byte NSendVat { get; set; }

    public string? CScheduleDate { get; set; }

    public string? CScheduleTime { get; set; }

    public byte? NNurAnGewerbliche { get; set; }

    public string? CUserProfilePayment { get; set; }

    public string? CUserProfileShipping { get; set; }

    public string? CUserProfileReturn { get; set; }

    public int? KEbayUser { get; set; }

    public string? CEbayUserName { get; set; }

    public string? CHtmlTemplateName { get; set; }

    public string CPlattform { get; set; } = null!;

    public DateTime? DEndtime { get; set; }

    public DateTime? DStarttime { get; set; }

    public string? CArtikelnummer { get; set; }

    public decimal? FArtikelEbayPreis { get; set; }

    public string? CArtikelKategorieName { get; set; }

    public decimal? FReserviert { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public byte? NUeberverkaeufeMoeglich { get; set; }

    public int? NEbayCategory1Id { get; set; }

    public int? NEbayCategory2Id { get; set; }

    public string? CEbayCategory1Name { get; set; }

    public string? CEbayCategory2Name { get; set; }

    public int NGesamtmenge { get; set; }

    public int NAngebotsmenge { get; set; }

    public int NVerkauft { get; set; }

    public string CFehler { get; set; } = null!;

    public int? NStreichPreisTyp { get; set; }

    public int? NGalleryType { get; set; }

    public int? NHitCounter { get; set; }

    public int? NListingType { get; set; }

    public int NRueckgabeMoeglich { get; set; }

    public int NScheduleServerSide { get; set; }

    public string? CZusatzoptionen { get; set; }

    public int NVorlageLaufend { get; set; }

    public string? CShopCategory { get; set; }

    public string? CShopCategory2 { get; set; }
}
