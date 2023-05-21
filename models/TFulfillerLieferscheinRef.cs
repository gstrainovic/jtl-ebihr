using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFulfillerLieferscheinRef
{
    public int KFulfillerLieferscheinRef { get; set; }

    public int KLieferschein { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? COwnerId { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TLieferschein KLieferscheinNavigation { get; set; } = null!;
}
