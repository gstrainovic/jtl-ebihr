using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRmgrundSprache
{
    public int KRmgrund { get; set; }

    public int KSprache { get; set; }

    public string CName { get; set; } = null!;

    public string? CBeschreibung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
