using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtEntwurfAnhang
{
    public int KNachrichtEntwurfAnhang { get; set; }

    public int KNachrichtEntwurf { get; set; }

    public int KAnhang { get; set; }

    public virtual TFile KAnhangNavigation { get; set; } = null!;

    public virtual TNachrichtEntwurf KNachrichtEntwurfNavigation { get; set; } = null!;
}
