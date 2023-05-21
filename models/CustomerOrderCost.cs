using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerOrderCost
{
    public int CustomerOrderCostId { get; set; }

    public int CustomerOrderId { get; set; }

    public int? CustomerOrderPosId { get; set; }

    public string? ProductNumber { get; set; }

    public byte CustomerOrderCostTypeId { get; set; }

    public decimal CostValue { get; set; }

    public string CostDescription { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime CalculationDate { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
