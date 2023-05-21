using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TResourceLabel
{
    public int KResource { get; set; }

    public int KLabel { get; set; }

    public virtual TResource KResourceNavigation { get; set; } = null!;
}
