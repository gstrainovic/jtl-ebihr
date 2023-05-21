using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExterneRechnungZusatzdaten
{
    public int KExterneRechnung { get; set; }

    public int? KFarbe { get; set; }

    public string? CAnmerkung { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public virtual TExterneRechnung KExterneRechnungNavigation { get; set; } = null!;
}
