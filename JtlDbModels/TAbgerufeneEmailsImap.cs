using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAbgerufeneEmailsImap
{
    public int KAbgerufeneEmailsImap { get; set; }

    public long NUniqueId { get; set; }

    public int KEingangskanalEmail { get; set; }

    public int? KNachricht { get; set; }

    public virtual TEingangskanalEmail KEingangskanalEmailNavigation { get; set; } = null!;

    public virtual TNachricht? KNachrichtNavigation { get; set; }
}
