using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAusgangskanalEmailOauth
{
    public int KAusgangskanalEmail { get; set; }

    public int KOauthToken { get; set; }

    public int NProvider { get; set; }

    public virtual TAusgangskanalEmail KAusgangskanalEmailNavigation { get; set; } = null!;

    public virtual TOauthToken KOauthTokenNavigation { get; set; } = null!;
}
