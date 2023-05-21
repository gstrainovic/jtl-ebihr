using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAgentLiestTicket
{
    public int KAgentLiestTicket { get; set; }

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public virtual TTicket KTicketNavigation { get; set; } = null!;
}
