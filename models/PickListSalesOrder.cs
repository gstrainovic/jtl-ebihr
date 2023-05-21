using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PickListSalesOrder
{
    public int InternalId { get; set; }

    public string SalesOrderNumber { get; set; } = null!;

    public string? Comment { get; set; }

    public string? ExternalSalesOrderNumber { get; set; }

    public string? CustomerSalesOrderNumber { get; set; }
}
