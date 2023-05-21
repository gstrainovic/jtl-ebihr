using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPictureShopMapping
{
    public int KPicture { get; set; }

    public int KShop { get; set; }

    public string CComputedHash { get; set; } = null!;

    public string CHash { get; set; } = null!;
}
