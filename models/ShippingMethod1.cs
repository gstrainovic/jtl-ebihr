using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ShippingMethod1
{
    public int InternalId { get; set; }

    public string? Name { get; set; }

    public decimal Price { get; set; }

    public decimal Vatrate { get; set; }

    public decimal ShippingCostsFree { get; set; }

    public decimal AdditionalWeight { get; set; }

    public byte? OwnShippingMethod { get; set; }

    public byte? TrackingIdMandatoryInput { get; set; }

    public int Priority { get; set; }

    public string? AmazonCarrierCode { get; set; }

    public string? CTrackingUrlTemplate { get; set; }

    public string? EbayCarrierCode { get; set; }

    public string? WeighingMandatory { get; set; }
}
