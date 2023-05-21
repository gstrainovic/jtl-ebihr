using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PickListPositionWarehouseConfiguration
{
    public int ConfigurationValueInternalId { get; set; }

    public int SalesOrderPositionInternalId { get; set; }

    public int? ProductInternalId { get; set; }

    public decimal AdditionalNetPrice { get; set; }

    public string ValueText { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int ConfigurationInternalId { get; set; }
}
