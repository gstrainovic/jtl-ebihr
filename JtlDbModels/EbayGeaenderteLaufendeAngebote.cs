using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayGeaenderteLaufendeAngebote
{
    public int KItem { get; set; }

    public int? NChanges { get; set; }

    public byte NTryUpload { get; set; }
}
