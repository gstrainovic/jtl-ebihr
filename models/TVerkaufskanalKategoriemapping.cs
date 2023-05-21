using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVerkaufskanalKategoriemapping
{
    public int KVerkaufskanalKategoriemapping { get; set; }

    public int KWawiKategorie { get; set; }

    public int KCategory { get; set; }

    public int KShopScx { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TShopScx KShopScxNavigation { get; set; } = null!;

    public virtual Tkategorie KWawiKategorieNavigation { get; set; } = null!;
}
