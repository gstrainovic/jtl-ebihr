using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmgrundWarengruppe
{
    public int KRmgrundWarengruppe { get; set; }

    public int KRmgrund { get; set; }

    public int KWarengruppe { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
