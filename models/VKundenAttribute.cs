using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKundenAttribute
{
    public int KKunde { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }
}
