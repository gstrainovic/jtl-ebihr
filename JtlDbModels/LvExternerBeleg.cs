using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvExternerBeleg
{
    public int KExternerBeleg { get; set; }

    public int KPlattform { get; set; }

    public string CBelegnr { get; set; } = null!;

    public DateTime DBelegdatumUtc { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public decimal? FVkBrutto { get; set; }

    public decimal? FVkNetto { get; set; }

    public int KFirma { get; set; }
}
