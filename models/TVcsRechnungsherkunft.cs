using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVcsRechnungsherkunft
{
    public int KUser { get; set; }

    public string COrderId { get; set; } = null!;

    public byte NVcsTyp { get; set; }
}
