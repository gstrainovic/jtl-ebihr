using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayAttributSetArray
{
    public int KItem { get; set; }

    public int AttributeSetId { get; set; }

    public int AttributeId { get; set; }

    public int? ValueId { get; set; }

    public string? ValueLiteral { get; set; }

    public int KCategoryId { get; set; }
}
