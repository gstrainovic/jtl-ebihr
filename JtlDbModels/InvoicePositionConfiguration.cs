using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class InvoicePositionConfiguration
{
    public int InternalId { get; set; }

    public int ConfigurationValueInternalId { get; set; }

    public int InvoicePositionInternalId { get; set; }

    public int? ProductInternalId { get; set; }

    public decimal AdditionalNetPrice { get; set; }

    public string ValueText { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int ConfigurationInternalId { get; set; }
}
