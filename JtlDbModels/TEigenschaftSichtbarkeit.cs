using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEigenschaftSichtbarkeit
{
    public int KEigenschaft { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
