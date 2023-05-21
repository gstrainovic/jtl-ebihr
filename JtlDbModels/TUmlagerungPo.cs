using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TUmlagerungPo
{
    public int KUmlagerungPos { get; set; }

    public int KUmlagerung { get; set; }

    public int KAuftragPosition { get; set; }

    public string? CSellerSku { get; set; }
}
