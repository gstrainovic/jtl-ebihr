using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VReturnReason
{
    public int KReturnReason { get; set; }

    public int KRmgrund { get; set; }

    public string CReturnReason { get; set; } = null!;
}
