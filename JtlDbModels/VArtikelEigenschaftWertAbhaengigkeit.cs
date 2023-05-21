using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelEigenschaftWertAbhaengigkeit
{
    public int? KEigenschaftWert { get; set; }

    public int? KEigenschaftWertZiel { get; set; }

    public int KEigenschaftWertAbhaengigkeit { get; set; }
}
