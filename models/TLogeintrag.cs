using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLogeintrag
{
    public int KLogeintrag { get; set; }

    public int KLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string? CMeldung { get; set; }

    public string? CAbgleichName { get; set; }

    public virtual TLogsitzung KLogsitzungNavigation { get; set; } = null!;
}
