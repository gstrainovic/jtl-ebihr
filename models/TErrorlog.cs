using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TErrorlog
{
    public int KErrorlog { get; set; }

    public string CRechnername { get; set; } = null!;

    public DateTime DErstelltUtc { get; set; }

    public bool NIstWorker { get; set; }

    public long NFehlerId { get; set; }

    public string CMeldung { get; set; } = null!;
}
