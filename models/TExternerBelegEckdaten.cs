using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExternerBelegEckdaten
{
    public int KExternerBeleg { get; set; }

    public decimal? FVkBrutto { get; set; }

    public decimal? FVkNetto { get; set; }

    public bool? BIstStorniert { get; set; }

    public virtual TExternerBeleg KExternerBelegNavigation { get; set; } = null!;
}
