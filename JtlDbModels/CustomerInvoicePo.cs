using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerInvoicePo
{
    public int CustomerInvoicePosId { get; set; }

    public int CustomerInvoiceId { get; set; }

    public int? CustomerOrderPosId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductNo { get; set; }

    public string? ProductName { get; set; }

    public decimal NetSalesPrice { get; set; }

    public decimal? NetPurchasePrice { get; set; }

    public decimal Amount { get; set; }

    public string? Unit { get; set; }

    public decimal Discount { get; set; }

    public decimal Vatpercent { get; set; }

    public byte PosType { get; set; }

    public int? ConfigurationPosId { get; set; }

    public int? PartsListPosId { get; set; }

    public int Sorting { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
