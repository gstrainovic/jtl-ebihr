using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TUmsatzzuordnungLog
{
    public int KUmsatzzuordnungLog { get; set; }

    public DateTime DDatum { get; set; }

    public string CDaten { get; set; } = null!;
}
