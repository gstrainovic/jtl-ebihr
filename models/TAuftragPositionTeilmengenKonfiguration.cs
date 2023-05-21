using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragPositionTeilmengenKonfiguration
{
    public int KDimension { get; set; }

    public int KAuftragPosition { get; set; }

    public decimal FValue { get; set; }

    public decimal FGroundValue { get; set; }

    public int? KMassEinheit { get; set; }

    public virtual TAuftragPosition KAuftragPositionNavigation { get; set; } = null!;

    public virtual TDimension KDimensionNavigation { get; set; } = null!;

    public virtual TMassEinheit? KMassEinheitNavigation { get; set; }
}
