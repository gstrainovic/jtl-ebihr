﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonItemMapping
{
    public int KItemMapping { get; set; }

    public int KItem { get; set; }

    public string CKey { get; set; } = null!;

    public string CValue { get; set; } = null!;
}
