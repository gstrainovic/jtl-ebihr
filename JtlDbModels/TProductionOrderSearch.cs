using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductionOrderSearch
{
    public int KProductionOrder { get; set; }

    public string CNummer { get; set; } = null!;

    public byte NType { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProductionOrder KProductionOrderNavigation { get; set; } = null!;
}
