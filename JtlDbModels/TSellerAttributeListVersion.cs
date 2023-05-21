using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSellerAttributeListVersion
{
    public int KSellerAttributeListVersion { get; set; }

    public string CAttributeListVersion { get; set; } = null!;

    public string CChannel { get; set; } = null!;
}
