using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRefreshToken
{
    public int KRefreshToken { get; set; }

    public string CRefreshToken { get; set; } = null!;

    public byte NType { get; set; }
}
