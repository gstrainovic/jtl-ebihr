using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCustomerQueryOverviewColumn
{
    public int KCustomerQueryOverview { get; set; }

    public int KUser { get; set; }

    public int NSqlIndex { get; set; }

    public int NGridIndex { get; set; }

    public int NWidth { get; set; }

    public virtual TCustomerQueryOverview KCustomerQueryOverviewNavigation { get; set; } = null!;
}
