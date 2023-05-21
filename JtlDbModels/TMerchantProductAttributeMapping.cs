using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMerchantProductAttributeMapping
{
    public int KAttribut { get; set; }

    public string CFfnName { get; set; } = null!;

    public virtual TAttribut KAttributNavigation { get; set; } = null!;
}
