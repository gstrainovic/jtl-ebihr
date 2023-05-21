using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonAngebotSelbstErstellt
{
    public string CSellerSku { get; set; } = null!;

    public string KUser { get; set; } = null!;

    public int NPlattform { get; set; }

    public int? KItem { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? NStatus { get; set; }
}
