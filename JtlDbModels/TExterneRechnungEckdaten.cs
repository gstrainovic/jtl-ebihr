using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TExterneRechnungEckdaten
{
    public int KExterneRechnung { get; set; }

    public decimal FSummeBrutto { get; set; }

    public decimal FSummeNetto { get; set; }

    public byte[] BRowVersionExterneRechnung { get; set; } = null!;

    public int NAnzahlPositionen { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TExterneRechnung KExterneRechnungNavigation { get; set; } = null!;
}
