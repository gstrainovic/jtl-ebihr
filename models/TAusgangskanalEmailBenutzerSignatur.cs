using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAusgangskanalEmailBenutzerSignatur
{
    public int KAusgangskanalEmailBenutzerSignatur { get; set; }

    public int KAusgangskanalEmail { get; set; }

    public int KBenutzer { get; set; }

    public int KFileHtmlInhalt { get; set; }

    public virtual TAusgangskanalEmail KAusgangskanalEmailNavigation { get; set; } = null!;

    public virtual TFile KFileHtmlInhaltNavigation { get; set; } = null!;
}
