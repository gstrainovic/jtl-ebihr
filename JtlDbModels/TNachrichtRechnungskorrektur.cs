using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtRechnungskorrektur
{
    public int KNachrichtRechnungskorrektur { get; set; }

    public int KNachricht { get; set; }

    public int KGutschrift { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
