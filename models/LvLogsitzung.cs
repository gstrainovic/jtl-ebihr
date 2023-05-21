using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvLogsitzung
{
    public int KSyncLogsitzung { get; set; }

    public int NTyp { get; set; }

    public int KBenutzer { get; set; }

    public string? CBenutzername { get; set; }

    public string CRechnername { get; set; } = null!;

    public DateTime DStart { get; set; }

    public DateTime? DEnde { get; set; }

    public byte? NStatus { get; set; }

    public string? CStatusMeldung { get; set; }
}
