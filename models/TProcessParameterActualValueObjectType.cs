using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProcessParameterActualValueObjectType
{
    public int KProcessParameterActualValueObjectType { get; set; }

    public int KProcessParameter { get; set; }

    public Guid IActualValueObjectType { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameter1 KProcessParameterNavigation { get; set; } = null!;

    public virtual ICollection<TProcessParameterAssignment1> TProcessParameterAssignment1s { get; set; } = new List<TProcessParameterAssignment1>();
}
