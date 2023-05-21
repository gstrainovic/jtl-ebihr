using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TKundeKategorieRabatt
{
    public int KKundeKategorieRabatt { get; set; }

    public int KKunde { get; set; }

    public int KKategorie { get; set; }

    public decimal FRabatt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
