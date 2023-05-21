using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEigenschaftWertAbhaengigkeit
{
    public int KEigenschaftWertAbhaengigkeit { get; set; }

    public int? KEigenschaftWert { get; set; }

    public int? KEigenschaftWertZiel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
