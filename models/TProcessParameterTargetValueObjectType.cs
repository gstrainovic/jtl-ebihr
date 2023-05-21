using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProcessParameterTargetValueObjectType
{
    public int KProcessParameterTargetValueObjectType { get; set; }

    public int KProcessParameter { get; set; }

    public Guid ITargetValueObjectType { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameter1 KProcessParameterNavigation { get; set; } = null!;

    public virtual ICollection<TProcessParameterAssignmentTargetValueObjectType> TProcessParameterAssignmentTargetValueObjectTypes { get; set; } = new List<TProcessParameterAssignmentTargetValueObjectType>();
}
