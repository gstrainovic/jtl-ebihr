using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TConfig
{
    public int? NRequestStatus { get; set; }

    public int? NRequestSource { get; set; }

    public string? CEmailSchedule { get; set; }
}
