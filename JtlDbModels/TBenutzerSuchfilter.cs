using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TBenutzerSuchfilter
{
    public int KBenutzerSuchfilter { get; set; }

    public int KBenutzer { get; set; }

    public int NFilterTyp { get; set; }

    public int NModus { get; set; }

    public string CName { get; set; } = null!;

    public string CValue { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
