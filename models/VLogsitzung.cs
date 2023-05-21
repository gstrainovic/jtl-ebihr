using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLogsitzung
{
    public long? KLogsitzung { get; set; }

    public int NTyp { get; set; }

    public int? KBenutzer { get; set; }

    public string? CBenutzername { get; set; }

    public string CRechnername { get; set; } = null!;

    public DateTime? DStart { get; set; }

    public DateTime? DEnde { get; set; }

    public int NStatus { get; set; }

    public string CStatusMeldung { get; set; } = null!;
}
