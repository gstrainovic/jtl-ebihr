﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VVcsLiteRechnungInvoiceByAmazonOffenerBeleg
{
    public string? InvoiceNumber { get; set; }

    public int KUser { get; set; }

    public DateTime? DVerarbeitetUtc { get; set; }

    public DateTime? DAktualisiertUtc { get; set; }
}
