using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TResourcesGroup
{
    public int KResource { get; set; }

    public int KResourceGroup { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TResourceGroup KResourceGroupNavigation { get; set; } = null!;

    public virtual TResource KResourceNavigation { get; set; } = null!;
}
