using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEingangskanalEmailLabel
{
    public int KEingangskanalEmailLabel { get; set; }

    public int KEingangskanalEmail { get; set; }

    public int KLabel { get; set; }

    public virtual TEingangskanalEmail KEingangskanalEmailNavigation { get; set; } = null!;

    public virtual TLabel KLabelNavigation { get; set; } = null!;
}
