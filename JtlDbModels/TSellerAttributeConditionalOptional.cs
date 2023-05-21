using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSellerAttributeConditionalOptional
{
    public int KSellerAttributeConditionalOptional { get; set; }

    public int KSellerAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public virtual TSellerAttribute KSellerAttributeNavigation { get; set; } = null!;
}
