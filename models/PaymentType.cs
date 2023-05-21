using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PaymentType
{
    public int PaymentTypeId { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
