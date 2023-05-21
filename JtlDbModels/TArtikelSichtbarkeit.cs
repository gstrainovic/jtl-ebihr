using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelSichtbarkeit
{
    public int KArtikel { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
