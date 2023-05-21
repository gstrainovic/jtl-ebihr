using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtRetoure
{
    public int KNachrichtRetoure { get; set; }

    public int KNachricht { get; set; }

    public int KRmretoure { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
