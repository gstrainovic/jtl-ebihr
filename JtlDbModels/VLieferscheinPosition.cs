using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLieferscheinPosition
{
    public int KLieferschein { get; set; }

    public int KLieferscheinPos { get; set; }

    public int? KBestellPos { get; set; }

    public decimal FAnzahl { get; set; }

    public string? CHinweis { get; set; }
}
