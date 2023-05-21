using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLogin
{
    public int KLogin { get; set; }

    public string CUserId { get; set; } = null!;

    public bool BFulfiller { get; set; }

    public bool BMerchant { get; set; }

    public string? CApiToken { get; set; }
}
