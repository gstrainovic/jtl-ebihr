using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PaymentType
{
    public int PaymentTypeId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
