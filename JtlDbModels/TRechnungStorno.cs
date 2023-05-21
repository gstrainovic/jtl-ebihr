using System;
using System.Collections.Generic;

namespace JtlDbModels;

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
