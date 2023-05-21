using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtEingangsrechnung
{
    public int KNachrichtEingangsrechnung { get; set; }

    public int KNachricht { get; set; }

    public int KEingangsrechnung { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
