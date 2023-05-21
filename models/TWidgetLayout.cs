using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWidgetLayout
{
    public int KWidgetLayout { get; set; }

    public int? KBenutzer { get; set; }

    public string? CLayout { get; set; }

    public string? CArbeitsplatz { get; set; }

    public int? NApplikation { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
