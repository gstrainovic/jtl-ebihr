using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelBildPlattform
{
    public int KArtikelBildPlattform { get; set; }

    public int KArtikel { get; set; }

    public int KShop { get; set; }

    public int KBild { get; set; }

    public int NNr { get; set; }

    public byte NInet { get; set; }
}
