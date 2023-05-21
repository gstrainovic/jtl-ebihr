using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TListViewExDateTimeFilter
{
    public int NListViewId { get; set; }

    public DateTime? DValue { get; set; }

    public int? NSelectedIndex { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
