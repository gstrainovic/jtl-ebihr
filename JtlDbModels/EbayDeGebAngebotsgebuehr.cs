using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDeGebAngebotsgebuehr
{
    public int KEbayDeGebAngebotsgebuehr { get; set; }

    public decimal PreisMin { get; set; }

    public decimal PreisMax { get; set; }

    public decimal Gebuehr { get; set; }
}
