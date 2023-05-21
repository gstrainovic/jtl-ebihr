using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCustomerQueryOverviewRecht
{
    public int KCustomerQueryOverview { get; set; }

    public int KRechtBenutzerGruppe { get; set; }

    public virtual TCustomerQueryOverview KCustomerQueryOverviewNavigation { get; set; } = null!;
}
