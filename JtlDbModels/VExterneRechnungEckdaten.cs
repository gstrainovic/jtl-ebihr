using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VExterneRechnungEckdaten
{
    public int KExterneRechnung { get; set; }

    public decimal FSummeBrutto { get; set; }

    public decimal FSummeNetto { get; set; }

    public int NStatus { get; set; }
}
