using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonBestandAnDatum
{
    public int KUser { get; set; }

    public string CSellerSku { get; set; } = null!;

    public DateTime DErstellt { get; set; }
}
