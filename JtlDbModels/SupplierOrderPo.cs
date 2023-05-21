using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SupplierOrderPo
{
    public int SupplierOrderPosId { get; set; }

    public int SupplierOrderId { get; set; }

    public int DeliveryNotePosId { get; set; }

    public int ProductId { get; set; }

    public string? ProductNo { get; set; }

    public string? ProductName { get; set; }

    public decimal Vatpercent { get; set; }

    public decimal AmountOrdered { get; set; }

    public decimal AmountDelivered { get; set; }

    public decimal NetPurchasePrice { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? PosType { get; set; }

    public int Sorting { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
