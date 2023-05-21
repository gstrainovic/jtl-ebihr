using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Trechnungnr
{
    public int KRechnungNr { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
