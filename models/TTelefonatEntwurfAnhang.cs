using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTelefonatEntwurfAnhang
{
    public int KTelefonatEntwurfAnhang { get; set; }

    public int KTelefonatEntwurf { get; set; }

    public int KAnhang { get; set; }

    public virtual TFile KAnhangNavigation { get; set; } = null!;

    public virtual TTelefonatEntwurf KTelefonatEntwurfNavigation { get; set; } = null!;
}
