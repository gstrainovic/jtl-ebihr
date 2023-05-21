using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TReturnReason
{
    public int KReturnReason { get; set; }

    public string CReturnReason { get; set; } = null!;

    public virtual ICollection<TRmgrund> TRmgrunds { get; set; } = new List<TRmgrund>();
}
