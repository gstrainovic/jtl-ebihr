using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCustomerQueryRecht
{
    public int KCustomerQuery { get; set; }

    public int KRechtBenutzerGruppe { get; set; }

    public virtual TCustomerQuery KCustomerQueryNavigation { get; set; } = null!;
}
