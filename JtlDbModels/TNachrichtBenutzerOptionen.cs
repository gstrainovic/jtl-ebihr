using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtBenutzerOptionen
{
    public int KNachrichtBenutzerOptionen { get; set; }

    public int KNachricht { get; set; }

    public int KBenutzer { get; set; }

    public bool NEingebetteteBilderAnzeigen { get; set; }

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
