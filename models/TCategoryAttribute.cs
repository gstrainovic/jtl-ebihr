using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCategoryAttribute
{
    public int KCategoryAttribute { get; set; }

    public int KCategory { get; set; }

    public int KChannel { get; set; }

    public string CAttributeId { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public bool NIsMultipleAllowed { get; set; }

    public string CType { get; set; } = null!;

    public string? CAttributeValueValidation { get; set; }

    public bool NRequired { get; set; }

    public string? CSection { get; set; }

    public int NSectionPosition { get; set; }

    public int NSubSectionPosition { get; set; }

    public string? CDescription { get; set; }

    public string? CSubSection { get; set; }

    public bool? NIsVariationDimension { get; set; }

    public bool NRecommended { get; set; }

    public bool NIsRepeatableSubSection { get; set; }

    public virtual TCategory KCategoryNavigation { get; set; } = null!;

    public virtual TChannel KChannelNavigation { get; set; } = null!;

    public virtual ICollection<TCategoryAttributeConditionalMandatory> TCategoryAttributeConditionalMandatories { get; set; } = new List<TCategoryAttributeConditionalMandatory>();

    public virtual ICollection<TCategoryAttributeConditionalOptional> TCategoryAttributeConditionalOptionals { get; set; } = new List<TCategoryAttributeConditionalOptional>();

    public virtual ICollection<TCategoryAttributeValue> TCategoryAttributeValues { get; set; } = new List<TCategoryAttributeValue>();
}
