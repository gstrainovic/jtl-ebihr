using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ExternalInvoicePosition
{
    public int InternalId { get; set; }

    public int? ExternalInvoicePositionParent { get; set; }

    public int ExternalInvoiceInternalId { get; set; }

    public DateTime OrderDate { get; set; }

    public string OrderNumber { get; set; } = null!;

    public string OrderCurrencyIso { get; set; } = null!;

    public DateTime? ShipmentDate { get; set; }

    public byte TransactionType { get; set; }

    public byte PositionType { get; set; }

    public int? ProductInternalId { get; set; }

    public string? Sku { get; set; }

    public string? TransactionText { get; set; }

    public decimal Quantity { get; set; }

    public DateTime TaxCalculationDate { get; set; }

    public decimal TaxRate { get; set; }

    public decimal GrossPriceTotal { get; set; }

    public decimal NetPriceTotal { get; set; }

    public decimal TaxTotal { get; set; }

    public decimal GrossDiscountTotal { get; set; }

    public decimal NetDiscountTotal { get; set; }

    public decimal TaxDiscountTotal { get; set; }

    public string CVersandadresseOrt { get; set; } = null!;

    public string? CVersandadresseRegion { get; set; }

    public string CVersandadresseLandIso { get; set; } = null!;

    public string CVersandadressePlz { get; set; } = null!;

    public string? CVersandadresseSteuercode { get; set; }

    public string CLieferadresseOrt { get; set; } = null!;

    public string? CLieferadresseRegion { get; set; }

    public string CLieferadresseLandIso { get; set; } = null!;

    public string CLieferadressePlz { get; set; } = null!;

    public string? CLieferadresseSteuercode { get; set; }

    public int? KAmazonVcsbestellungPos { get; set; }

    public int? SalesOrderPositionInternalId { get; set; }
}
