using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbgerufeneEmailsPop3
{
    public int KAbgerufeneEmailsPop3 { get; set; }

    public string CUniqueId { get; set; } = null!;

    public int KEingangskanalEmail { get; set; }

    public int? KNachricht { get; set; }

    public virtual TEingangskanalEmail KEingangskanalEmailNavigation { get; set; } = null!;

    public virtual TNachricht? KNachrichtNavigation { get; set; }
}
