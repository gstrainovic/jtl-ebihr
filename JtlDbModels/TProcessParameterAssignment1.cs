using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterAssignment1
{
    public int KProcessParameterAssignment { get; set; }

    public int KProcessParameter { get; set; }

    public int KAssignmentObject { get; set; }

    public int NUsageType { get; set; }

    public int? KProcessParameterActualValueObjectType { get; set; }

    public bool NIsActualValueRequired { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameterActualValueObjectType? KProcessParameterActualValueObjectTypeNavigation { get; set; }

    public virtual TProcessParameter1 KProcessParameterNavigation { get; set; } = null!;

    public virtual ICollection<TProcessParameterActualValue> TProcessParameterActualValues { get; set; } = new List<TProcessParameterActualValue>();

    public virtual ICollection<TProcessParameterAssignmentTargetValueObjectType> TProcessParameterAssignmentTargetValueObjectTypes { get; set; } = new List<TProcessParameterAssignmentTargetValueObjectType>();
}
