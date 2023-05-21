using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShippingRule
{
    public int KShippingRule { get; set; }

    public int KChannel { get; set; }

    public string CCarrierId { get; set; } = null!;

    public string? CDisplayName { get; set; }

    public virtual TChannel KChannelNavigation { get; set; } = null!;
}
