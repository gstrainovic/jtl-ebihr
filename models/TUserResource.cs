using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUserResource
{
    public int KUserResource { get; set; }

    public int KResource { get; set; }

    public int? KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TResource KResourceNavigation { get; set; } = null!;
}
