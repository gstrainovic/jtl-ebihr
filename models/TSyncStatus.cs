using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSyncStatus
{
    public int? KPlattform { get; set; }

    public int? KShop { get; set; }

    public int? KSyncType { get; set; }

    public byte[]? BStartRowversion { get; set; }
}
