using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachrichtAngebot
{
    public int KNachrichtAngebot { get; set; }

    public int KNachricht { get; set; }

    public int KAuftrag { get; set; }

    public string CMatchingWord { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
