﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxZahlungsmethoden
{
    public int SiteId { get; set; }

    public string PaymentOption { get; set; } = null!;

    public string DisplayText { get; set; } = null!;
}
