using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSellerAttributeListVersion
{
    public int KSellerAttributeListVersion { get; set; }

    public string CAttributeListVersion { get; set; } = null!;

    public string CChannel { get; set; } = null!;
}
