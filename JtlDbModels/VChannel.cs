﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VChannel
{
    public int KChannel { get; set; }

    public string CChannel { get; set; } = null!;

    public string CName { get; set; } = null!;
}
