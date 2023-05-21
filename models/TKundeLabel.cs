using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TKundeLabel
{
    public int KKunde { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
