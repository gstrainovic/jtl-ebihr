using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungLabel
{
    public int KRechnung { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;
}
