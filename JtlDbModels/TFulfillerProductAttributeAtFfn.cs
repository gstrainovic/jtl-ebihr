using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFulfillerProductAttributeAtFfn
{
    public int KFulfillerProductAttributeAtFfn { get; set; }

    public int KProductRef { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string CMerchantId { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string CType { get; set; } = null!;

    public string CValue { get; set; } = null!;

    public virtual TProductRef KProductRefNavigation { get; set; } = null!;
}
