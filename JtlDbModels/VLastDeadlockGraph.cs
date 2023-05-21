using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLastDeadlockGraph
{
    public DateTime? TimeStamp { get; set; }

    public string? DeadlockGraph { get; set; }
}
