using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmstatusSprache
{
    public int KRmstatus { get; set; }

    public int KSprache { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
