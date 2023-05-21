using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftragUpdateAttribute
{
    public int KAuftrag { get; set; }

    public string CKey { get; set; } = null!;

    public string? CValue { get; set; }
}
