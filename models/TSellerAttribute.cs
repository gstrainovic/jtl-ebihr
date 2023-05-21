using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSellerAttribute
{
    public int KSellerAttribute { get; set; }

    public string CSellerId { get; set; } = null!;

    public string CAttributeId { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public bool NIsMultipleAllowed { get; set; }

    public string? CType { get; set; }

    public string? CAttributeValueValidation { get; set; }

    public bool NRequired { get; set; }

    public string? CSection { get; set; }

    public int NSectionPosition { get; set; }

    public string? CSubSection { get; set; }

    public int NSubSectionPosition { get; set; }

    public string? CDescription { get; set; }

    public bool? NIsVariationDimension { get; set; }

    public int KShop { get; set; }

    public bool NRecommended { get; set; }

    public bool NIsRepeatableSubSection { get; set; }

    public virtual TShop KShopNavigation { get; set; } = null!;

    public virtual ICollection<TSellerAttributeConditionalMandatory> TSellerAttributeConditionalMandatories { get; set; } = new List<TSellerAttributeConditionalMandatory>();

    public virtual ICollection<TSellerAttributeConditionalOptional> TSellerAttributeConditionalOptionals { get; set; } = new List<TSellerAttributeConditionalOptional>();

    public virtual ICollection<TSellerAttributeValue> TSellerAttributeValues { get; set; } = new List<TSellerAttributeValue>();
}
