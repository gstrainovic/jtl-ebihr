using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TGutschriftStornogrund
{
    public int KGutschriftStornogrund { get; set; }

    public string CStornogrund { get; set; } = null!;
}
