using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TotalsInvoice
{
    public int InvoiceInternalId { get; set; }

    public decimal Vatrate { get; set; }

    public decimal? Vatsum { get; set; }

    public decimal? GrossPriceTotal { get; set; }

    public decimal? NetPriceTotal { get; set; }

    public decimal? GrossPriceShippingPositionTotal { get; set; }

    public decimal? NetPriceShippingPositionTotal { get; set; }

    public decimal? ShippingCostsVat { get; set; }

    public decimal? DiscountValueTotal { get; set; }

    public decimal? GrossPriceCodchargeTotal { get; set; }
}
