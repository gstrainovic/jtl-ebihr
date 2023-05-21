using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TChannelAttributeValue
{
    public int KChannelAttributeValue { get; set; }

    public int KChannelAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public int NSort { get; set; }

    public virtual TChannelAttribute KChannelAttributeNavigation { get; set; } = null!;
}
