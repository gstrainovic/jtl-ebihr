using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTextFiltersSplitStreetExpression
{
    public string CIso { get; set; } = null!;

    public string CRegEx { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
