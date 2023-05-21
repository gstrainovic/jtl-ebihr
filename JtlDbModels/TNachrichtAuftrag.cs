using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtAuftrag
{
    public int KNachrichtAuftrag { get; set; }

    public int KNachricht { get; set; }

    public int KAuftrag { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
