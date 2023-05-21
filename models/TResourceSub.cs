using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TResourceSub
{
    public int KResource { get; set; }

    public int KSubResource { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TResource KResourceNavigation { get; set; } = null!;

    public virtual TResource KSubResourceNavigation { get; set; } = null!;
}
