using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayVwHtmltemplatedatum
{
    public int KEbayHtmlTemplateData { get; set; }

    public byte[] BData { get; set; } = null!;

    public string? CTemplate { get; set; }
}
