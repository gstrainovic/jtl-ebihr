using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRetoureEtikett
{
    public int KRmretourenEtikett { get; set; }

    public int KRmretoure { get; set; }

    public string? CIdentCode { get; set; }

    public DateTime? DErstellt { get; set; }
}
