using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductionOrderLabel
{
    public int KProductionOrder { get; set; }

    public int KLabel { get; set; }

    public virtual TProductionOrder KProductionOrderNavigation { get; set; } = null!;
}
