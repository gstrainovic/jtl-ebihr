using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TReportsDataSet
{
    public int? KReports { get; set; }

    public string? CDataSet { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
