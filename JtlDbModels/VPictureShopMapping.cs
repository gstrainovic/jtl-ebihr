using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VPictureShopMapping
{
    public int KPicture { get; set; }

    public int KShop { get; set; }

    public string CComputedHash { get; set; } = null!;

    public string CHash { get; set; } = null!;
}
