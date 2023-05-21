using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvExterneRechnung
{
    public int KExterneRechnung { get; set; }

    public int KPlattform { get; set; }

    public string CExterneRechnungsnr { get; set; } = null!;

    public DateTime DBelegzeitpunktUtc { get; set; }

    public string? CWaehrungIso { get; set; }

    public decimal FSummeBrutto { get; set; }

    public decimal FSummeNetto { get; set; }

    public int KFirma { get; set; }
}
