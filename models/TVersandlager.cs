using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVersandlager
{
    public int KWarenlager { get; set; }

    public byte? NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
