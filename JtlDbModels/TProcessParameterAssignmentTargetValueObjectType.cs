using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterAssignmentTargetValueObjectType
{
    public int KProcessParameterAssignmentTargetValueObjectType { get; set; }

    public int KProcessParameterAssignment { get; set; }

    public int KProcessParameterTargetValueObjectType { get; set; }

    public bool NIsTargetValueRequired { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameterAssignment1 KProcessParameterAssignmentNavigation { get; set; } = null!;

    public virtual TProcessParameterTargetValueObjectType KProcessParameterTargetValueObjectTypeNavigation { get; set; } = null!;

    public virtual ICollection<TProcessParameterTargetValue> TProcessParameterTargetValues { get; set; } = new List<TProcessParameterTargetValue>();
}
