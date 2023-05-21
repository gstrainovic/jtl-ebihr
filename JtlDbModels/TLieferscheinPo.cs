using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferscheinPo
{
    public int KLieferscheinPos { get; set; }

    public int KLieferschein { get; set; }

    public int? KBestellPos { get; set; }

    public decimal FAnzahl { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TRechnungLieferscheinPosition> TRechnungLieferscheinPositions { get; set; } = new List<TRechnungLieferscheinPosition>();
}
