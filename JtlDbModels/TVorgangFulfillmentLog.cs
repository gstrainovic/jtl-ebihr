using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVorgangFulfillmentLog
{
    public int KVorgangFulfillmentLog { get; set; }

    public int KVorgang { get; set; }

    public int KFulfillmentLog { get; set; }
}
