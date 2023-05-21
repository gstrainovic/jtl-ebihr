using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAmazonSfpShippingdatum
{
    public int KVersand { get; set; }

    public decimal PackageWeight { get; set; }

    public byte ShippingMethodAutoCalcWeight { get; set; }

    public decimal ShippingMethodWeight { get; set; }

    public decimal ShippingMethodHeight { get; set; }

    public decimal ShippingMethodLength { get; set; }

    public decimal ShippingMethodWidth { get; set; }

    public decimal ShippingMethodMinWeight { get; set; }

    public byte ShippingMethodCarrierWillPickUp { get; set; }

    public byte ShippingMethodUseInsurance { get; set; }

    public byte? ShippingMethodUseWarhouseAddress { get; set; }
}
