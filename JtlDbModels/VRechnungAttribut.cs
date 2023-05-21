using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnungAttribut
{
    public int KRechnung { get; set; }

    public int KAttribut { get; set; }

    public int KSprache { get; set; }

    public string? CValue { get; set; }

    public string CName { get; set; } = null!;
}
