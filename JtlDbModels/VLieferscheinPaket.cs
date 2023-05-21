using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLieferscheinPaket
{
    public int KLieferschein { get; set; }

    public int KVersand { get; set; }

    public string? CLogistiker { get; set; }

    public string? CLogistikUrl { get; set; }

    public string? CIdentCode { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CHinweis { get; set; }
}
