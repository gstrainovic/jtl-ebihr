﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSteuerSammelkonten
{
    public int KSteuerSammelkonten { get; set; }

    public string CName { get; set; } = null!;

    public string CSammelkonto { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
