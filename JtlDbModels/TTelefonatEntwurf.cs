using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTelefonatEntwurf
{
    public int KTelefonatEntwurf { get; set; }

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public int NRichtung { get; set; }

    public string? CTelefonnummer { get; set; }

    public int KFileHtmlInhalt { get; set; }

    public DateTime DErstellung { get; set; }

    public virtual TFile KFileHtmlInhaltNavigation { get; set; } = null!;

    public virtual TTicket KTicketNavigation { get; set; } = null!;

    public virtual ICollection<TTelefonatEntwurfAnhang> TTelefonatEntwurfAnhangs { get; set; } = new List<TTelefonatEntwurfAnhang>();
}
