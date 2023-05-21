using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TXsell
{
    public int KXsell { get; set; }

    public int KArtikel { get; set; }

    public int KXsellArtikel { get; set; }

    public int? KXsellGruppe { get; set; }

    public byte? NEigenesFeld { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
