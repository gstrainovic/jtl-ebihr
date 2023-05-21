using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxCondition
{
    public int SiteId { get; set; }

    public int Id { get; set; }

    public string DisplayName { get; set; } = null!;
}
