using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAuftragspositionsvariation
{
    public int KBestellung { get; set; }

    public int KBestellPos { get; set; }

    public string CWert { get; set; } = null!;
}
