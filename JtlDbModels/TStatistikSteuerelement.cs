﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatistikSteuerelement
{
    public int KStatistikVorlage { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
