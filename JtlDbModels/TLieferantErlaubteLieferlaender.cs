﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferantErlaubteLieferlaender
{
    public int KLieferant { get; set; }

    public string CIso { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
