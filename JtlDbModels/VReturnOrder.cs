using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VReturnOrder
{
    public int KAuftrag { get; set; }

    public int? KKunde { get; set; }

    public int KFirma { get; set; }

    public int KWarehouseReturn { get; set; }

    public string? COrderId { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;
}
