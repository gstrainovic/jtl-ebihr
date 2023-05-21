using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragAttribut
{
    public int KAuftragAttribut { get; set; }

    public int KAuftrag { get; set; }

    public int KAttribut { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;

    public virtual ICollection<TAuftragAttributSprache> TAuftragAttributSpraches { get; set; } = new List<TAuftragAttributSprache>();
}
