using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonQueue
{
    public int KAmazonQueue { get; set; }

    public int KUser { get; set; }

    public int NKey { get; set; }

    public string? CFeed { get; set; }

    public string? CValue { get; set; }

    public byte NStatus { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DGesendet { get; set; }
}
