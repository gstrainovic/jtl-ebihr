﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VEbayItemCustomPolicy
{
    public int KItem { get; set; }

    public int KEbayuser { get; set; }

    public string? CId { get; set; }

    public string? CType { get; set; }
}
