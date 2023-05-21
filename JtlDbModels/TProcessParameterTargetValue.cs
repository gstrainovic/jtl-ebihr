using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterTargetValue
{
    public int KProcessParameterTargetValue { get; set; }

    public int KProcessParameterAssignmentTargetValueObjectType { get; set; }

    public int KTargetValueObject { get; set; }

    public int? NValueInt { get; set; }

    public decimal? NValueDecimal { get; set; }

    public string? CValueText { get; set; }

    public DateTimeOffset? DValueDateTime { get; set; }

    public int? KFile { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameterAssignmentTargetValueObjectType KProcessParameterAssignmentTargetValueObjectTypeNavigation { get; set; } = null!;
}
