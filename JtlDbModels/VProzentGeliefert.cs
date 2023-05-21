using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VProzentGeliefert
{
    public int KBestellung { get; set; }

    public decimal? ProzGeliefert { get; set; }

    public decimal? ProzAufLieferschein { get; set; }
}
