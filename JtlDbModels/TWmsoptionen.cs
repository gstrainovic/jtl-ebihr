﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWmsoptionen
{
    public string? CName { get; set; }

    public string? CWert { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
