using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExternOffer
{
    public long KExternOffer { get; set; }

    public long KOffer { get; set; }

    public string? CTitle { get; set; }

    public string? CSku { get; set; }

    public string? CGtin { get; set; }

    public int NAktion { get; set; }

    public string? CJsonAttributes { get; set; }

    public virtual TOffer KOfferNavigation { get; set; } = null!;
}
