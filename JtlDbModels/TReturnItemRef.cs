using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TReturnItemRef
{
    public int KReturnItemRef { get; set; }

    public int KReturnRef { get; set; }

    public int KRmRetoure { get; set; }

    public int? KRmRetourePos { get; set; }

    public int? KLieferscheinPos { get; set; }

    public string CReturnItemId { get; set; } = null!;

    public decimal FQuantity { get; set; }

    public byte NType { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? COwnerId { get; set; }

    public byte[] BRowVersion { get; set; } = null!;
}
