using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungStorno
{
    public int KRechnung { get; set; }

    public int KBenutzer { get; set; }

    public int KRechnungStornogrund { get; set; }

    public DateTime DStorniert { get; set; }

    public string? CKommentar { get; set; }

    public int KStornoGutschrift { get; set; }

    public virtual Tgutschrift KStornoGutschriftNavigation { get; set; } = null!;
}
