using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTelefonat
{
    public int KTelefonat { get; set; }

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public int NRichtung { get; set; }

    public string CTelefonnummer { get; set; } = null!;

    public int KFileHtmlInhalt { get; set; }

    public DateTime DErstellung { get; set; }

    public virtual TFile KFileHtmlInhaltNavigation { get; set; } = null!;

    public virtual TTicket KTicketNavigation { get; set; } = null!;

    public virtual ICollection<TAgentAngeseheneTicket> TAgentAngeseheneTickets { get; set; } = new List<TAgentAngeseheneTicket>();

    public virtual ICollection<TTelefonatAnhang> TTelefonatAnhangs { get; set; } = new List<TTelefonatAnhang>();
}
