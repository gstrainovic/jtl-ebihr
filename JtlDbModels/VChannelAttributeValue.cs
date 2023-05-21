using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VChannelAttributeValue
{
    public string CAttributeId { get; set; } = null!;

    public string CValue { get; set; } = null!;

    public int KShopScx { get; set; }
}
