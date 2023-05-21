using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTextFiltersSplitStreetException
{
    public string CIso { get; set; } = null!;

    public string CException { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
