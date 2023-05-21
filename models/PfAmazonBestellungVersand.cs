using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonBestellungVersand
{
    public int KAmazonBestellungVersand { get; set; }

    public int? KAmazonBestellungPos { get; set; }

    public int? KLieferschein { get; set; }

    public int? NQuantity { get; set; }

    public int? KBenutzer { get; set; }

    public string? CCarrierCode { get; set; }

    public string? CCarrierName { get; set; }

    public string? CTrackingNumber { get; set; }

    public string? CShipMethod { get; set; }

    public DateTime? DShipDate { get; set; }

    public DateTime? DBearbeitet { get; set; }

    public string? CShipFromAddressName { get; set; }

    public string? CShipFromAddressLine1 { get; set; }

    public string? CShipFromAddressLine2 { get; set; }

    public string? CShipFromAddressLine3 { get; set; }

    public string? CShipFromAddressCity { get; set; }

    public string? CShipFromAddressCounty { get; set; }

    public string? CShipFromAddressStateOrRegion { get; set; }

    public string? CShipFromPostalcode { get; set; }

    public string? CShipFromCountrycode { get; set; }
}
