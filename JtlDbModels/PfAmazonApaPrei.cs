﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonApaPrei
{
    public string? CSellerSku { get; set; }

    public int? NPlattform { get; set; }

    public decimal FPreis { get; set; }

    public DateTime? DErstellt { get; set; }
}
