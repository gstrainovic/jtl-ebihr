using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragLabel
{
    public int KAuftrag { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;
}
