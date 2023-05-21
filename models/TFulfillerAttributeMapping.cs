using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFulfillerAttributeMapping
{
    public int KFulfillerAttributeMapping { get; set; }

    public string CMerchantId { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string CType { get; set; } = null!;

    public int? KAttribut { get; set; }

    public virtual TAttribut? KAttributNavigation { get; set; }
}
