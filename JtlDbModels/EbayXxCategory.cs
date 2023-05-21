using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxCategory
{
    public int SiteId { get; set; }

    public int CategoryId { get; set; }

    public int CategoryParentId { get; set; }

    public byte CategoryLevel { get; set; }

    public string CategoryName { get; set; } = null!;

    public byte LeafCategory { get; set; }

    public byte VariationsEnabled { get; set; }

    public byte ConditionEnabled { get; set; }

    public string ConditionValues { get; set; } = null!;

    public byte ItemSpecificsEnabled { get; set; }

    public byte AttributeConversionEnabled { get; set; }

    public byte ItemCompatibilityEnabled { get; set; }

    public string CompatibleVehicleType { get; set; } = null!;

    public byte ProductRequiredEnabled { get; set; }
}
