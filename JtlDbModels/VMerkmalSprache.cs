using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerkmalSprache
{
    public int KSprache { get; set; }

    public int KMerkmal { get; set; }

    public string? CName { get; set; }
}
