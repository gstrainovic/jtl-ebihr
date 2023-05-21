using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferavisSeriennummer
{
    public int KLieferavisSeriennummer { get; set; }

    public int KLieferavisPosition { get; set; }

    public string CSeriennummer { get; set; } = null!;

    public virtual TLieferavisPosition KLieferavisPositionNavigation { get; set; } = null!;
}
