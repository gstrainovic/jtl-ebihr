using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbgleichToken
{
    public int KAbgleichToken { get; set; }

    public string CAbgleichToken { get; set; } = null!;

    public DateTime DAenderung { get; set; }

    public DateTime DErstellt { get; set; }
}
