using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachrichtRechnung
{
    public int KNachrichtRechnung { get; set; }

    public int KNachricht { get; set; }

    public int KRechnung { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
