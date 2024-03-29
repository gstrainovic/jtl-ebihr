﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayTransactionDeleted
{
    public string ItemId { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public DateTime DeletedAt { get; set; }

    public bool? NCheckout { get; set; }
}
