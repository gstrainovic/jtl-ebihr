using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayItem
{
    public int KItem { get; set; }

    public string? ApplicationData { get; set; }

    public byte? ApplyShippingDiscount { get; set; }

    public byte? AutoPay { get; set; }

    public byte? BestOfferEnabled { get; set; }

    public byte? BusinessSeller { get; set; }

    public decimal BuyItNowPrice { get; set; }

    public string? BuyerProtection { get; set; }

    public byte? CategoryBasedAttributesPrefill { get; set; }

    public byte? CategoryMappingAllowed { get; set; }

    public byte? ChangePaymentInstructions { get; set; }

    public string Country { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public byte? DispatchTimeMax { get; set; }

    public string? GalleryType { get; set; }

    public string? GalleryUrl { get; set; }

    public byte? GetItFast { get; set; }

    public byte? GiftIcon { get; set; }

    public string? GiftServices { get; set; }

    public int? HitCount { get; set; }

    public string? HitCounter { get; set; }

    public string? ItemId { get; set; }

    public byte? LinkedPayPalAccount { get; set; }

    public string? ListingDuration { get; set; }

    public string? ListingEnhancement { get; set; }

    public string? ListingType { get; set; }

    public string? Location { get; set; }

    public int? LotSize { get; set; }

    public byte? NowAndNew { get; set; }

    public string? PayPalEmailAddress { get; set; }

    public string? PaymentMethods { get; set; }

    public string? PhotoDisplay { get; set; }

    public string? PictureUrl { get; set; }

    public string? PostalCode { get; set; }

    public int PrimaryCategoryId { get; set; }

    public int Quantity { get; set; }

    public int? QuestionCount { get; set; }

    public decimal ReservePrice { get; set; }

    public byte? RestrictedToBusiness { get; set; }

    public string? Sku { get; set; }

    public int? SsBidderCount { get; set; }

    public decimal SsCurrentPrice { get; set; }

    public string? SsHighBidderUserId { get; set; }

    public string? ScheduleDate { get; set; }

    public string? ScheduleTime { get; set; }

    public int? SecondaryCategoryId { get; set; }

    public string? ShipToLocations { get; set; }

    public string? ShippingTerms { get; set; }

    public byte? ShippingTermsInDescription { get; set; }

    public string? ShippingType { get; set; }

    public string Site { get; set; } = null!;

    public decimal StartPrice { get; set; }

    public long? StoreCategory2Id { get; set; }

    public long? StoreCategoryId { get; set; }

    public string? SubTitle { get; set; }

    public byte? ThirdPartyCheckout { get; set; }

    public string? Title { get; set; }

    public string? Uuid { get; set; }

    public decimal Vatpercent { get; set; }

    public int? WatchCount { get; set; }

    public string? Type { get; set; }

    public string? ScheduleServerSide { get; set; }

    public int? KArtikel { get; set; }

    public int KEbayuser { get; set; }

    public int HtmlTemplate { get; set; }

    public string? Sent { get; set; }

    public decimal Totalfees { get; set; }

    public int? SsBidCount { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public byte? Status { get; set; }

    public string? Templatename { get; set; }

    public string? ListingUrl { get; set; }

    public int? KPlanung { get; set; }

    public int? KPlanungsItem { get; set; }

    public string? CRelistedItemId { get; set; }

    public decimal FGewicht { get; set; }

    public int? KKategorie { get; set; }

    public decimal BestOfferMinPrice { get; set; }

    public int? KTemplate { get; set; }

    public byte? NVksonderregel { get; set; }

    public string? DiscountProfileId { get; set; }

    public byte? NPickup { get; set; }

    public byte? NPremium { get; set; }

    public string? CRelistId { get; set; }

    public decimal BestOfferAutoAcceptPrice { get; set; }

    public byte? NVksonderregelInt { get; set; }

    public string? DiscountProfileIdint { get; set; }

    public byte? NVariationenAktiv { get; set; }

    public int? KEigenschaft { get; set; }

    public byte? NReturnPolicy { get; set; }

    public int? ConditionId { get; set; }

    public int? NLaufend { get; set; }

    public int? MaxQuantity { get; set; }

    public byte? NAutomatischEinstellen { get; set; }

    public int? NSchwelleAutomatischEinstellen { get; set; }

    public byte? NLeecher { get; set; }

    public int SiteId { get; set; }

    public string CRueckgabeMoeglich { get; set; } = null!;

    public string? CRueckgabefrist { get; set; }

    public string? CVersandkostenTraeger { get; set; }

    public byte? BBestandReserviert { get; set; }

    public byte NUseHomeShippingCostTable { get; set; }

    public byte NUseInternationalShippingCostTable { get; set; }

    public DateTime? DZuEbayGesendet { get; set; }

    public int? NFehler { get; set; }

    public long KMessage { get; set; }

    public string? CEbayUserProfileIdShipping { get; set; }

    public string? CEbayUserProfileIdPayment { get; set; }

    public string? CEbayUserProfileIdReturn { get; set; }

    public string? ConditionDescription { get; set; }

    public byte? NEbayPlus { get; set; }

    public byte? NProduktKennzeichnung { get; set; }

    public string? CEan { get; set; }

    public int? NMinQuantity { get; set; }

    public byte? NNurAnGewerbliche { get; set; }

    public byte NSendVat { get; set; }

    public byte IncludeeBayProductDetails { get; set; }

    public byte? PrivateListing { get; set; }

    public string? CPaymentInstructions { get; set; }

    public byte BIstVerkaufsaktion { get; set; }

    public decimal? FStreichPreis { get; set; }

    public string? CStreichPreisTyp { get; set; }

    public string? CInternationaleRueckgabeMoeglich { get; set; }

    public string? CInternationaleRueckgabefrist { get; set; }

    public string? CInternationalerVersandkostenTraeger { get; set; }

    public string? CTakeBackId { get; set; }

    public virtual ICollection<TNegotiationAngebotStatus> TNegotiationAngebotStatuses { get; set; } = new List<TNegotiationAngebotStatus>();

    public virtual ICollection<TNegotiationAngebot> TNegotiationAngebots { get; set; } = new List<TNegotiationAngebot>();

    public virtual ICollection<TNegotiationAutomatisierung> TNegotiationAutomatisierungs { get; set; } = new List<TNegotiationAutomatisierung>();

    public virtual ICollection<TNegotiationItem> TNegotiationItems { get; set; } = new List<TNegotiationItem>();

    public virtual ICollection<TNegotiationVerlauf> TNegotiationVerlaufs { get; set; } = new List<TNegotiationVerlauf>();
}
