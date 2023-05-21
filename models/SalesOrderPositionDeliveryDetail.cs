﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SalesOrderPositionDeliveryDetail
{
    public int? SalesOrderPositionInternalId { get; set; }

    public decimal? Quantity { get; set; }

    public string? BatchNumber { get; set; }

    public DateTime? BestBeforeDate { get; set; }

    public string? SerialNumber { get; set; }
}
