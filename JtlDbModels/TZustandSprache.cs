﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZustandSprache
{
    public int KZustand { get; set; }

    public int KSprache { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
