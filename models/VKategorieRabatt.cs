using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKategorieRabatt
{
    public int KKundengruppe { get; set; }

    public int KKategorie { get; set; }

    public decimal FRabatt { get; set; }

    public int KShop { get; set; }
}
