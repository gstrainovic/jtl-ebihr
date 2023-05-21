using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TExterneRechnungPositionZusatzdaten
{
    public int KExterneRechnungPosition { get; set; }

    public string? CAnmerkung { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TExterneRechnungPosition KExterneRechnungPositionNavigation { get; set; } = null!;
}
