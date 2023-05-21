using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSyncLogsitzung
{
    public int KSyncLogsitzung { get; set; }

    public int NTyp { get; set; }

    public int KBenutzer { get; set; }

    public string CRechnername { get; set; } = null!;

    public DateTime DStart { get; set; }

    public DateTime? DEnde { get; set; }

    public byte? NStatus { get; set; }

    public string? CStatusMeldung { get; set; }

    public virtual ICollection<TConnectorLogeintrag> TConnectorLogeintrags { get; set; } = new List<TConnectorLogeintrag>();

    public virtual ICollection<TDbeSlogeintrag> TDbeSlogeintrags { get; set; } = new List<TDbeSlogeintrag>();

    public virtual ICollection<TPosLogeintrag> TPosLogeintrags { get; set; } = new List<TPosLogeintrag>();

    public virtual ICollection<TScxLogeintrag> TScxLogeintrags { get; set; } = new List<TScxLogeintrag>();
}
