using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFeatureFlag
{
    public int KFeatureFlag { get; set; }

    public string CFeatureCode { get; set; } = null!;

    public bool BActivated { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
