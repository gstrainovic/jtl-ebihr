using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VShopKundengruppe
{
    public int KShop { get; set; }

    public int KKundenGruppe { get; set; }

    public byte? NStandard { get; set; }
}
