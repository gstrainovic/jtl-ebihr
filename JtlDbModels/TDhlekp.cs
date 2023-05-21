using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDhlekp
{
    public int KDhlekp { get; set; }

    public string CEkp { get; set; } = null!;

    public string? CAnmerkung { get; set; }

    public int KShipperAccount { get; set; }

    public int? KParentDhlekp { get; set; }

    public virtual TShipperAccount KShipperAccountNavigation { get; set; } = null!;
}
