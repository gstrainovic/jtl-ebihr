using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VChannelAttribute
{
    public int KShop { get; set; }

    public int KShopScx { get; set; }

    public int KChannel { get; set; }

    public string CChannelDisplayName { get; set; } = null!;

    public string? CAttributeId { get; set; }

    public string? CDisplayName { get; set; }

    public bool? NIsMultipleAllowed { get; set; }

    public string? CType { get; set; }

    public string? CAttributeValueValidation { get; set; }

    public bool? NRequired { get; set; }

    public string? CSection { get; set; }

    public int? NSectionPosition { get; set; }

    public string? CSubSection { get; set; }

    public int? NSubSectionPosition { get; set; }

    public string? CDescription { get; set; }

    public bool? NIsVariationDimension { get; set; }

    public bool? NIsRepeatableSubSection { get; set; }
}
