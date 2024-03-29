﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvVcsLiteBuchungsdaten
{
    public string? TransactionId { get; set; }

    public string OrderId { get; set; } = null!;

    public int KUser { get; set; }

    public DateTime? ShippingDate { get; set; }
}
