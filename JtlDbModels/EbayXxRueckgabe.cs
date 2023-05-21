using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxRueckgabe
{
    public int SiteId { get; set; }

    public string CType { get; set; } = null!;

    public string COption { get; set; } = null!;

    public string CDescription { get; set; } = null!;
}
