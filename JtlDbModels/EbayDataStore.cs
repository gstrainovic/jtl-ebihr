﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDataStore
{
    public int KStore { get; set; }

    public int? KEbayUser { get; set; }

    public string? Name { get; set; }

    public string? SubscriptionLevel { get; set; }

    public string? Url { get; set; }
}
