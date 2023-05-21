using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnungStornierbar
{
    public int KRechnung { get; set; }

    public string CRechnungsnr { get; set; } = null!;

    public int NError { get; set; }
}
