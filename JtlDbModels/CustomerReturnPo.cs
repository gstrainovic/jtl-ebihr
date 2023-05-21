using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerReturnPo
{
    public int CustomerReturnPosId { get; set; }

    public int CustomerReturnId { get; set; }

    public int ReturnReasonId { get; set; }

    public int ProductId { get; set; }

    public int? ProductStateId { get; set; }

    public int DeliveryNotePosId { get; set; }

    public decimal Amount { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
