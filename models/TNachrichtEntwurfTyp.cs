using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachrichtEntwurfTyp
{
    public int KNachrichtEntwurfTyp { get; set; }

    public int KNachrichtEntwurf { get; set; }

    public int KAntwortkanal { get; set; }

    public int NAntwortTyp { get; set; }

    public virtual TAntwortkanal KAntwortkanalNavigation { get; set; } = null!;

    public virtual TNachrichtEntwurf KNachrichtEntwurfNavigation { get; set; } = null!;
}
