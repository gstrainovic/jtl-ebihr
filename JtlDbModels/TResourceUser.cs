using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TResourceUser
{
    public int KResource { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TResource KResourceNavigation { get; set; } = null!;
}
