using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragStornogrund
{
    public int KAuftragStornogrund { get; set; }

    public string CStornogrund { get; set; } = null!;

    public int NAmazonMapping { get; set; }

    public string CScxMapping { get; set; } = null!;

    public virtual ICollection<TAuftragStorno> TAuftragStornos { get; set; } = new List<TAuftragStorno>();
}
