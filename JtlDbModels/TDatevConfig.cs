using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDatevConfig
{
    public int KFirma { get; set; }

    public string TOauthConfigCId { get; set; } = null!;

    public int NBeraterNummer { get; set; }

    public int NMandantenNummer { get; set; }

    public DateTime? DAbgleichStartDatum { get; set; }

    public bool? BUseSandbox { get; set; }
}
