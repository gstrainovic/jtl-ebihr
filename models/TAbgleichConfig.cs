using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbgleichConfig
{
    public int KAbgleichConfig { get; set; }

    public string CAbgleichName { get; set; } = null!;

    public int? NAbgleichGroesse { get; set; }
}
