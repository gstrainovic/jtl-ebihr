using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VSteuercache
{
    public int KFirma { get; set; }

    public decimal FSteuersatz { get; set; }

    public int? KSteuerKlasse { get; set; }

    public int KSteuerZone { get; set; }
}
