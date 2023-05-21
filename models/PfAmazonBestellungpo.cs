using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonBestellungpo
{
    public int KAmazonBestellungPos { get; set; }

    public int KAmazonBestellung { get; set; }

    public string? CArtNr { get; set; }

    public string? CName { get; set; }

    public int NQuantityPurchased { get; set; }

    public decimal FItemPrice { get; set; }

    public decimal FItemTax { get; set; }

    public decimal FShippingPrice { get; set; }

    public decimal FShippingTax { get; set; }

    public string? COrderItemId { get; set; }

    public int? NVersandt { get; set; }

    public string? CCarrier { get; set; }

    public string? CTrackingNumber { get; set; }

    public DateTime? DEstimatedArrivalDate { get; set; }

    public string? CFulfillmentCenterId { get; set; }

    public string? CFulfillmentChannel { get; set; }

    public string? CMerchantOrderItemId { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorMessage { get; set; }

    public DateTime? DErrorErstellt { get; set; }

    public decimal? FGeschenkverpackungKosten { get; set; }

    public string? CGeschenkverpackungTyp { get; set; }

    public string? CGrusstext { get; set; }

    public byte? NGeschenk { get; set; }

    public int? KFulfillmentAuftragPos { get; set; }

    public decimal? FPreisNetto { get; set; }

    public bool NCustom { get; set; }

    public string? CCustomJson { get; set; }

    public string? CCustomUrl { get; set; }

    public string? CShipCountry { get; set; }

    public string? CArchiveUrl { get; set; }

    public virtual ICollection<TAuftragPosition> TAuftragPositions { get; set; } = new List<TAuftragPosition>();
}
