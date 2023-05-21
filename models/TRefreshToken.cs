using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRefreshToken
{
    public int KRefreshToken { get; set; }

    public string CRefreshToken { get; set; } = null!;

    public byte NType { get; set; }
}
