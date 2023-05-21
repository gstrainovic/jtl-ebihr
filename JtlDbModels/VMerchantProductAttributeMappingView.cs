using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMerchantProductAttributeMappingView
{
    public int KAttribut { get; set; }

    public string CName { get; set; } = null!;

    public byte NIstEigenesFeld { get; set; }

    public string? CGruppe { get; set; }

    public string CFeldTyp { get; set; } = null!;

    public byte NDatenTyp { get; set; }

    public string? CFfnName { get; set; }
}
