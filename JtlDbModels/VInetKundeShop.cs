using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VInetKundeShop
{
    public int KInetKunde { get; set; }

    public int KShop { get; set; }

    public int KKundenGruppe { get; set; }

    public string? DKundeSeit { get; set; }

    public string? CInet { get; set; }

    public int? KKunde { get; set; }

    public short? NRegistriert { get; set; }

    public string? CShopKundenNr { get; set; }
}
