﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVcsSelfInvoicePosMapping
{
    public int KAmazonBestellungPos { get; set; }

    public int KBestellPos { get; set; }

    public int KVcsdata { get; set; }

    public decimal NQuantity { get; set; }
}
