using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSyncDelete
{
    public int? KPlattform { get; set; }

    public int? KShop { get; set; }

    public string? CTabelle { get; set; }

    public int? KKey { get; set; }

    public byte[]? BRowversion { get; set; }
}
