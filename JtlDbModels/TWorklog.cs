using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorklog
{
    public int KWorkerlog { get; set; }

    public string CMessage { get; set; } = null!;

    public long NErrorId { get; set; }

    public DateTime DDate { get; set; }
}
