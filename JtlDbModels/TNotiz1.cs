using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNotiz1
{
    public int KNotiz { get; set; }

    public string? CBeschreibung { get; set; }

    public DateTime DErstellung { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public int KFileHtmlInhalt { get; set; }

    public virtual TFile KFileHtmlInhaltNavigation { get; set; } = null!;

    public virtual TTicket KTicketNavigation { get; set; } = null!;

    public virtual ICollection<TAgentAngeseheneTicket> TAgentAngeseheneTickets { get; set; } = new List<TAgentAngeseheneTicket>();

    public virtual ICollection<TNotizAnhang> TNotizAnhangs { get; set; } = new List<TNotizAnhang>();
}
