using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrder1
{
    public int KAuftrag { get; set; }

    public string? COrderId { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public int? KKunde { get; set; }
}
