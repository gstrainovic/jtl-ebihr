﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VMappedProductKey
{
    public int KArtikel { get; set; }

    public string? CInet { get; set; }

    public string? CJpid { get; set; }

    public int NAktion { get; set; }
}
