using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class GoodsOut
{
    public int GoodsOutId { get; set; }

    public int GoodsInId { get; set; }

    public int? BinLocationId { get; set; }

    public int MovementTypeId { get; set; }

    public int DeliveryNotePosId { get; set; }

    public int ProductId { get; set; }

    public int? SystemUserId { get; set; }

    public DateTime? CreationDate { get; set; }

    public decimal Amount { get; set; }

    public string? GoodsOutComment { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
