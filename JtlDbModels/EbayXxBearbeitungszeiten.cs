using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxBearbeitungszeiten
{
    public int SiteId { get; set; }

    public string CDispatchTime { get; set; } = null!;
}
