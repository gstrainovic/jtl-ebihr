using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VFulfillerProductPicture
{
    public int KArtikelbildPlattform { get; set; }

    public int KArtikel { get; set; }

    public int KPlattform { get; set; }

    public int NNr { get; set; }

    public int KShop { get; set; }

    public int KEbayUser { get; set; }

    public int KBild { get; set; }

    public byte[] BBildRowVersion { get; set; } = null!;

    public byte[] BBild { get; set; } = null!;
}
