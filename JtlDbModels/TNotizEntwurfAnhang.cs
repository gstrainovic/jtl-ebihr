using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNotizEntwurfAnhang
{
    public int KNotizEntwurfAnhang { get; set; }

    public int KNotizEntwurf { get; set; }

    public int KAnhang { get; set; }

    public virtual TFile KAnhangNavigation { get; set; } = null!;

    public virtual TNotizEntwurf KNotizEntwurfNavigation { get; set; } = null!;
}
