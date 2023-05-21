using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TReportsDataSet
{
    public int? KReports { get; set; }

    public string? CDataSet { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
