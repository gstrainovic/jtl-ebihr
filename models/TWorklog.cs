using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorklog
{
    public int KWorkerlog { get; set; }

    public string CMessage { get; set; } = null!;

    public long NErrorId { get; set; }

    public DateTime DDate { get; set; }
}
