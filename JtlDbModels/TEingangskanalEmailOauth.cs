using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEingangskanalEmailOauth
{
    public int KEingangskanalEmail { get; set; }

    public int KOauthToken { get; set; }

    public int NProvider { get; set; }

    public virtual TEingangskanalEmail KEingangskanalEmailNavigation { get; set; } = null!;

    public virtual TOauthToken KOauthTokenNavigation { get; set; } = null!;
}
