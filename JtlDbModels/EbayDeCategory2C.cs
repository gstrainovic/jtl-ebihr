using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDeCategory2C
{
    public int CategoryId { get; set; }

    public int AttributeSetId { get; set; }

    public int? AttributeSetVersion { get; set; }

    public string? Name { get; set; }
}
