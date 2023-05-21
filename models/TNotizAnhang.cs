using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNotizAnhang
{
    public int KNotizAnhang { get; set; }

    public int KNotiz { get; set; }

    public int KAnhang { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TFile KAnhangNavigation { get; set; } = null!;

    public virtual TNotiz1 KNotizNavigation { get; set; } = null!;
}
