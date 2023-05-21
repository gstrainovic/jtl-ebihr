using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVcsRechnungskorrekturherkunft
{
    public int KUser { get; set; }

    public string COrderId { get; set; } = null!;

    public byte NVcsTyp { get; set; }
}
