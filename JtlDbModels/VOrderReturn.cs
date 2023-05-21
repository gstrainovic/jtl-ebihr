using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderReturn
{
    public int KAuftrag { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public string? COrderId { get; set; }

    public int KSellerReturnId { get; set; }

    public string? CChannelReturnId { get; set; }
}
