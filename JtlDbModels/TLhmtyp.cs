﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLhmtyp
{
    public int KLhmtyp { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
