﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VProductPosAttribute
{
    public int KProduct { get; set; }

    public string CName { get; set; } = null!;

    public string? CValue { get; set; }

    public decimal? FValueDecimal { get; set; }
}
