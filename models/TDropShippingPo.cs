using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDropShippingPo
{
    public int KBestellPos { get; set; }

    public int KLieferantenBestellungPos { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
