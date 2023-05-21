using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelAbnahme
{
    public int KArtikel { get; set; }

    public int KKundengruppe { get; set; }

    public decimal FIntervall { get; set; }

    public decimal FMindestabnahme { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
