using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderSerialNumber
{
    public int KOrder { get; set; }

    public int KOrderPos { get; set; }

    public string? CSerialNumber { get; set; }
}
