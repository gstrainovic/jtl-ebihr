using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtPreisanfrage
{
    public int KNachrichtPreisanfrage { get; set; }

    public int KNachricht { get; set; }

    public int KLieferantenbestellung { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
