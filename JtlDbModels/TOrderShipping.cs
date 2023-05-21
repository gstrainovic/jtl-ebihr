using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOrderShipping
{
    public int KOrderShipping { get; set; }

    public int KOrder { get; set; }

    public int KLieferschein { get; set; }

    public DateTime DCreatedAtUtc { get; set; }

    public DateTime? DUploadedAtUtc { get; set; }

    public byte NCount { get; set; }

    public virtual TLieferschein KLieferscheinNavigation { get; set; } = null!;
}
