using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProductionOrderLabel
{
    public int KProductionOrder { get; set; }

    public int KLabel { get; set; }

    public virtual TProductionOrder KProductionOrderNavigation { get; set; } = null!;
}
