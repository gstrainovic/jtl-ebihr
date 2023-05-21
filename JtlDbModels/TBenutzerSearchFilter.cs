using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBenutzerSearchFilter
{
    public int KBenutzerSearchFilter { get; set; }

    public int KBenutzer { get; set; }

    public string CFilterType { get; set; } = null!;

    public bool NShared { get; set; }

    public string CName { get; set; } = null!;

    public string CValue { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
