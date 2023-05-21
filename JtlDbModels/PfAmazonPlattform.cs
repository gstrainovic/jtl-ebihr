using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonPlattform
{
    public int KPlattform { get; set; }

    public string CMarketPlaceId { get; set; } = null!;

    public int NRegion { get; set; }
}
