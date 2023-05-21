using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTelefonatAnhang
{
    public int KTelefonatAnhang { get; set; }

    public int KTelefonat { get; set; }

    public int KAnhang { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TFile KAnhangNavigation { get; set; } = null!;

    public virtual TTelefonat KTelefonatNavigation { get; set; } = null!;
}
