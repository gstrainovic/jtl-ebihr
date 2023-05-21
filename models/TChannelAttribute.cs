using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TChannelAttribute
{
    public int KChannelAttribute { get; set; }

    public int KChannel { get; set; }

    public string CAttributeId { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public bool NIsMultipleAllowed { get; set; }

    public string CType { get; set; } = null!;

    public string? CAttributeValueValidation { get; set; }

    public bool NRequired { get; set; }

    public string? CSection { get; set; }

    public int NSectionPosition { get; set; }

    public string? CSubSection { get; set; }

    public int NSubSectionPosition { get; set; }

    public string? CDescription { get; set; }

    public bool? NIsVariationDimension { get; set; }

    public bool NRecommended { get; set; }

    public bool NIsRepeatableSubSection { get; set; }

    public virtual TChannel KChannelNavigation { get; set; } = null!;

    public virtual ICollection<TChannelAttributeConditionalMandatory> TChannelAttributeConditionalMandatories { get; set; } = new List<TChannelAttributeConditionalMandatory>();

    public virtual ICollection<TChannelAttributeConditionalOptional> TChannelAttributeConditionalOptionals { get; set; } = new List<TChannelAttributeConditionalOptional>();

    public virtual ICollection<TChannelAttributeValue> TChannelAttributeValues { get; set; } = new List<TChannelAttributeValue>();
}
