﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLhmattribut
{
    public int KLhmattribut { get; set; }

    public int KLhm { get; set; }

    public string CAttribut { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
