﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMerchantStockChangeRef
{
    public int KMerchantStockChangeRef { get; set; }

    public int KMerchantStockChange { get; set; }

    public int? KWarenlagerEingang { get; set; }

    public int? KWarenlagerAusgang { get; set; }
}
