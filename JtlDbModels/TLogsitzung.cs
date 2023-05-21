using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLogsitzung
{
    public int KLogsitzung { get; set; }

    public int KBenutzer { get; set; }

    public string? CRechnername { get; set; }

    public DateTime DStart { get; set; }

    public DateTime? DEnde { get; set; }

    public byte? NStatus { get; set; }

    public string? CStatusMeldung { get; set; }

    public virtual ICollection<TLogeintrag> TLogeintrags { get; set; } = new List<TLogeintrag>();
}
