using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TReport
{
    public int KReports { get; set; }

    public string? CName { get; set; }

    public string? CData { get; set; }

    public string? CTyp { get; set; }

    public string? CDataSet { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
