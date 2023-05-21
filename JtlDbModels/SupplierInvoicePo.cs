using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SupplierInvoicePo
{
    public int SupplierInvoicePosId { get; set; }

    public int? SupplierInvoiceId { get; set; }

    public int? SupplierOrderId { get; set; }

    public int? ProductId { get; set; }

    public decimal Amount { get; set; }

    public decimal NetPurchasePrice { get; set; }

    public decimal Vatpercent { get; set; }

    public byte? PosType { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
