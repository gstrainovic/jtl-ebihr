using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKategorieRabatt
{
    public int KKategorie { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public decimal FRabatt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
