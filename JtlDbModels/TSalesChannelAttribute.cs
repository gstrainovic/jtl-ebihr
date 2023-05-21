using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSalesChannelAttribute
{
    public string CChannel { get; set; } = null!;

    public string? CAttribute { get; set; }

    public string CValue { get; set; } = null!;
}
