using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWmsInventurlogSubset
{
    public int KWmsInventurlogSubsets { get; set; }

    public int KWmsInventurlog { get; set; }

    public string CSubsetNumber { get; set; } = null!;

    public int FQuantity { get; set; }

    public decimal FFactor { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
