using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUpdateLog
{
    public int KUpdateLog { get; set; }

    public string CModul { get; set; } = null!;

    public DateTime DZeitstempel { get; set; }

    public int NSchweregrad { get; set; }

    public int KBenutzer { get; set; }

    public string CMeldung { get; set; } = null!;
}
