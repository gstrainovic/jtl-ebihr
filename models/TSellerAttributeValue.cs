using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSellerAttributeValue
{
    public int KSellerAttributeValue { get; set; }

    public int KSellerAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public int NSort { get; set; }

    public virtual TSellerAttribute KSellerAttributeNavigation { get; set; } = null!;
}
