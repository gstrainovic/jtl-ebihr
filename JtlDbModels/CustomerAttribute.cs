using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerAttribute
{
    public int InternalId { get; set; }

    public int CustomerInternalId { get; set; }

    public string AttributeName { get; set; } = null!;

    public string? AttributeValue { get; set; }

    public string? AttributeDescription { get; set; }

    public int LanguageInternalId { get; set; }
}
