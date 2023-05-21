using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TChannelAttributeConditionalMandatory
{
    public int KChannelAttributeConditionalMandatory { get; set; }

    public int KChannelAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public virtual TChannelAttribute KChannelAttributeNavigation { get; set; } = null!;
}
