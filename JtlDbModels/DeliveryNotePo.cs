using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class DeliveryNotePo
{
    public int DeliveryNotePosId { get; set; }

    public int DeliveryNoteId { get; set; }

    public int? CustomerOrderPosId { get; set; }

    public int PickTime { get; set; }

    public decimal Amount { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
