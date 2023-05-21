using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNotizEntwurf
{
    public int KNotizEntwurf { get; set; }

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public string? CBetreff { get; set; }

    public DateTime DErstelldatum { get; set; }

    public int? KFileHtmlInhalt { get; set; }

    public virtual TFile? KFileHtmlInhaltNavigation { get; set; }

    public virtual TTicket KTicketNavigation { get; set; } = null!;

    public virtual ICollection<TNotizEntwurfAnhang> TNotizEntwurfAnhangs { get; set; } = new List<TNotizEntwurfAnhang>();
}
