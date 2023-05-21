using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVerpackenSubsetDetail
{
    public int KVerpackenSubset { get; set; }

    public int KDimension { get; set; }

    public decimal FValue { get; set; }

    public decimal FGroundValue { get; set; }

    public int? KMassEinheit { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
