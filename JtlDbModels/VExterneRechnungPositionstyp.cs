using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VExterneRechnungPositionstyp
{
    public int? Freiposition { get; set; }

    public int? Artikel { get; set; }

    public int? Versandkosten { get; set; }

    public int? Geschenkverpackung { get; set; }
}
