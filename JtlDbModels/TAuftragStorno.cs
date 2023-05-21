using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragStorno
{
    public int KAuftrag { get; set; }

    public int KBenutzer { get; set; }

    public int KAuftragStornogrund { get; set; }

    public DateTime DStorniert { get; set; }

    public string? CKommentar { get; set; }

    public virtual TAuftragStornogrund KAuftragStornogrundNavigation { get; set; } = null!;
}
