using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAmazonBestellungPo
{
    public string? CName { get; set; }

    public string? CArtNr { get; set; }

    public int NQuantityPurchased { get; set; }

    public decimal? FItemPrice { get; set; }

    public int NVersandStatus { get; set; }

    public string? CCarrier { get; set; }

    public string? CTrackingNumber { get; set; }

    public DateTime? DEstimatedArrivalDate { get; set; }

    public string? CFulfillmentCenterId { get; set; }

    public string? CFulfillmentChannel { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorMessage { get; set; }

    public decimal? FGeschenkVerpackungskosten { get; set; }

    public string? CGeschenkVerpackungstyp { get; set; }

    public string? CGrusstext { get; set; }

    public int KAmazonBestellungPos { get; set; }

    public int KAmazonBestellung { get; set; }

    public int VersandNachrichtCode { get; set; }

    public string? CCustomUrl { get; set; }
}
