using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SupplierInvoicePosExtraCharge
{
    public int SupplierInvoicePosExtraChargesId { get; set; }

    public int SupplierInvoicePosId { get; set; }

    public decimal ChargeValue { get; set; }

    public string? CurrencyIso { get; set; }

    public decimal CurrencyFactor { get; set; }

    public decimal Vatpercent { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
