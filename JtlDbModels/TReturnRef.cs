using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TReturnRef
{
    public int KReturnRef { get; set; }

    public int? KRmRetoure { get; set; }

    public byte NType { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? COwnerId { get; set; }

    public string? CReturnId { get; set; }

    public byte? NChangeState { get; set; }

    public string? CWarehouseId { get; set; }

    public DateTimeOffset DLastWawiUpdate { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TRmretoure? KRmRetoureNavigation { get; set; }
}
