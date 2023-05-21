using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAngebote1
{
    public long KOffer { get; set; }

    public int? KArtikel { get; set; }

    public string? CSku { get; set; }

    public string? CArtNr { get; set; }

    public string? COfferTitle { get; set; }

    public string? CChannelName { get; set; }

    public int? KChannel { get; set; }

    public string? CChannel { get; set; }

    public int KShop { get; set; }

    public decimal FQuantity { get; set; }

    public byte NStatus { get; set; }

    public string? CErrorMessage { get; set; }

    public DateTime? DExpirationDate { get; set; }

    public int KCategory { get; set; }

    public string? CChannelCategoryId { get; set; }

    public string? CChannelCategoryName { get; set; }

    public decimal? FNettoPreis { get; set; }

    public decimal? FProzent { get; set; }

    public int? KPreis { get; set; }

    public int? KKundenGruppe { get; set; }

    public decimal? FVknetto { get; set; }

    public int? KSteuerklasse { get; set; }

    public int? KFirma { get; set; }

    public string? CWaehrung { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public decimal? FInAuftraegen { get; set; }

    public decimal? FZulauf { get; set; }

    public string? CGtin { get; set; }

    public decimal? FArtGewicht { get; set; }

    public string? CHan { get; set; }

    public string? CIsbn { get; set; }

    public string? CAsin { get; set; }

    public string? CHersteller { get; set; }

    public decimal? FEknetto { get; set; }

    public DateTime? DActiveSince { get; set; }

    public int? NBearbeitungszeit { get; set; }

    public DateTime? DZulaufVerfuegbarAm { get; set; }

    public byte? NType { get; set; }

    public byte NAngebotstyp { get; set; }

    public int NWawiStatus { get; set; }

    public string? CListingUrl { get; set; }

    public bool? NIsListed { get; set; }

    public int? KVerkaufskanalArtikelData { get; set; }

    public decimal? FMindestBestand { get; set; }

    public decimal? FMaximalerBestand { get; set; }

    public DateTime? DLetzterUpload { get; set; }

    public int NLoeschintervallSchwebendAngebot { get; set; }

    public string? CShopname { get; set; }

    public bool? NIsExtern { get; set; }

    public DateTime? DQuantityUpdatedAt { get; set; }

    public DateTime? DPriceUpdatedUtc { get; set; }

    public DateTime? DStatusReceivedUtc { get; set; }

    public decimal? FZuletztHochgeladenerPreis { get; set; }
}
