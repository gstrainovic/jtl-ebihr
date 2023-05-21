using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNachrichtEntwurf
{
    public int KNachrichtEntwurf { get; set; }

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public string? CBetreff { get; set; }

    public DateTime DErstelldatum { get; set; }

    public int? KFileHtmlInhalt { get; set; }

    public int? KAusgangskanalEmail { get; set; }

    public virtual TAusgangskanalEmail? KAusgangskanalEmailNavigation { get; set; }

    public virtual TFile? KFileHtmlInhaltNavigation { get; set; }

    public virtual TTicket KTicketNavigation { get; set; } = null!;

    public virtual ICollection<TNachrichtEntwurfAnhang> TNachrichtEntwurfAnhangs { get; set; } = new List<TNachrichtEntwurfAnhang>();

    public virtual ICollection<TNachrichtEntwurfTyp> TNachrichtEntwurfTyps { get; set; } = new List<TNachrichtEntwurfTyp>();
}
