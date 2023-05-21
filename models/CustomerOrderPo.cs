using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerOrderPo
{
    public int CustomerOrderPosId { get; set; }

    public int CustomerOrderId { get; set; }

    public byte CustomerOrderPosTypeId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductNumber { get; set; }

    public string? ProductName { get; set; }

    public decimal NetSalesPrice { get; set; }

    public decimal NetPurchasePrice { get; set; }

    public decimal Amount { get; set; }

    public string? Unit { get; set; }

    public decimal Discount { get; set; }

    public decimal Vatpercent { get; set; }

    public int? ConfigurationPosId { get; set; }

    public int? PartsListPosId { get; set; }

    public int Sorting { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
