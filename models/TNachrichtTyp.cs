using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachrichtTyp
{
    public int KNachrichtTyp { get; set; }

    public int KNachricht { get; set; }

    public int KAntwortkanal { get; set; }

    public int NAntwortTyp { get; set; }

    public virtual TAntwortkanal KAntwortkanalNavigation { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
