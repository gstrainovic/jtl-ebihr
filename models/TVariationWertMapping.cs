using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVariationWertMapping
{
    public int KVariationWertMapping { get; set; }

    public int KChannel { get; set; }

    public int? KCategory { get; set; }

    public string CWawiVariationWert { get; set; } = null!;

    public string CScxVariationWert { get; set; } = null!;
}
