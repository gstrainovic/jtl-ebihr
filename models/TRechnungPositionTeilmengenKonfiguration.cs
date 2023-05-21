using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungPositionTeilmengenKonfiguration
{
    public int KDimension { get; set; }

    public int KRechnungPosition { get; set; }

    public decimal FValue { get; set; }

    public decimal FGroundValue { get; set; }

    public int? KMassEinheit { get; set; }

    public virtual TDimension KDimensionNavigation { get; set; } = null!;

    public virtual TMassEinheit? KMassEinheitNavigation { get; set; }

    public virtual TRechnungPosition KRechnungPositionNavigation { get; set; } = null!;
}
