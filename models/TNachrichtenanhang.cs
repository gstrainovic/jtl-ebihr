using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachrichtenanhang
{
    public int KNachrichtenanhang { get; set; }

    public int KNachricht { get; set; }

    public int KAnhang { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NFreigabeStatus { get; set; }

    public int? KBenutzerFreigabeStatus { get; set; }

    public byte NTyp { get; set; }

    public virtual TFile KAnhangNavigation { get; set; } = null!;

    public virtual TNachricht KNachrichtNavigation { get; set; } = null!;
}
