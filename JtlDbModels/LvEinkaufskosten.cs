using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvEinkaufskosten
{
    public int KAuftrag { get; set; }

    public decimal? FKalkKosten { get; set; }

    public decimal? FKosten { get; set; }
}
