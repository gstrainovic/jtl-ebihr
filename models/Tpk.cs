﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tpk
{
    public string CName { get; set; } = null!;

    public int? Nummer { get; set; }

    public string? DChanged { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
