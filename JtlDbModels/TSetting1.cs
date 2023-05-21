using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSetting1
{
    public string CKey { get; set; } = null!;

    public string? CStringValue { get; set; }

    public int? NIntValue { get; set; }

    public decimal? FDoubleValue { get; set; }

    public DateTimeOffset? DDateValue { get; set; }
}
