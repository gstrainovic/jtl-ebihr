using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKundenAttribut
{
    public int KKunde { get; set; }

    public string CName { get; set; } = null!;

    public string? CWert { get; set; }
}
