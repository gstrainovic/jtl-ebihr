using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tangebotnr
{
    public int KAngebotNr { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
