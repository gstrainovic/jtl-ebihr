using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCustomerQueryUser
{
    public int KCustomerQueryUser { get; set; }

    public int KBenutzer { get; set; }

    public int KCustomerQuery { get; set; }

    public string? CFormatConditions { get; set; }

    public virtual TCustomerQuery KCustomerQueryNavigation { get; set; } = null!;

    public virtual ICollection<TCustomerQueryColumn> TCustomerQueryColumns { get; set; } = new List<TCustomerQueryColumn>();
}
