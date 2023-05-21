using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonAngebotMapping
{
    public int KArtikel { get; set; }

    public string CSellerSku { get; set; } = null!;

    public int KUser { get; set; }
}
