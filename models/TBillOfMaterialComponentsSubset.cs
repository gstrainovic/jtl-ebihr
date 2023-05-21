using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBillOfMaterialComponentsSubset
{
    public int KDimension { get; set; }

    public int KBillOfMaterialComponent { get; set; }

    public decimal FValue { get; set; }

    public decimal FGroundValue { get; set; }

    public int? KMassEinheit { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TBillOfMaterialComponent KBillOfMaterialComponentNavigation { get; set; } = null!;

    public virtual TDimension KDimensionNavigation { get; set; } = null!;

    public virtual TMassEinheit? KMassEinheitNavigation { get; set; }
}
