using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKundengruppeAttribut
{
    public int KKundengruppeAttribut { get; set; }

    public int KKundengruppe { get; set; }

    public string? CName { get; set; }

    public string? CWert { get; set; }
}
