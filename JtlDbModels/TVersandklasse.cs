﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandklasse
{
    public int KVersandklasse { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
