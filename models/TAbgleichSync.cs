﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbgleichSync
{
    public int KAbgleichSync { get; set; }

    public string CAbgleichName { get; set; } = null!;

    public byte[] BLastChange { get; set; } = null!;

    public bool NKomplettAbgleich { get; set; }
}
