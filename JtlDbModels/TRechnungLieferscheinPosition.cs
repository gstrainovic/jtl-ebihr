using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRechnungLieferscheinPosition
{
    public int KRechnungPosition { get; set; }

    public int KLieferscheinPosition { get; set; }

    public decimal FAnzahlAufRechnung { get; set; }

    public virtual TLieferscheinPo KLieferscheinPositionNavigation { get; set; } = null!;

    public virtual TRechnungPosition KRechnungPositionNavigation { get; set; } = null!;
}
