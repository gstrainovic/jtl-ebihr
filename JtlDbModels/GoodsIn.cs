using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class GoodsIn
{
    public int GoodsInId { get; set; }

    public int BinLocationId { get; set; }

    public int ProductId { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CustomerOrderPosId { get; set; }

    public int MovementTypeId { get; set; }

    public int? SupplierOrderPosId { get; set; }

    public int? CustomerReturnPosId { get; set; }

    public int? CustomerCreditNotePosId { get; set; }

    public int SystemUserId { get; set; }

    public decimal NetPurchasePrice { get; set; }

    public decimal Amount { get; set; }

    public DateTime? BestBeforeDate { get; set; }

    public string? BatchName { get; set; }

    public string? GoodsInComment { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
