﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TMerchantProductUpdateQueue
{
    public int KMerchantProductUpdateQueue { get; set; }

    public int KArtikel { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public int? NProcessing { get; set; }
}
