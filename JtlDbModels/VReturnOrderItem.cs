using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VReturnOrderItem
{
    public int KAuftrag { get; set; }

    public int KLieferscheinPos { get; set; }

    public int? KArtikel { get; set; }

    public int KAuftragPosition { get; set; }

    public string COrderItemId { get; set; } = null!;

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public string? ProductNumber { get; set; }

    public string? ProductName { get; set; }
}
