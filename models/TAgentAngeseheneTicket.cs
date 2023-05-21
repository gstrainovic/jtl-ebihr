using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAgentAngeseheneTicket
{
    public int KAgentAngeseheneTickets { get; set; }

    public int KTicket { get; set; }

    public int? KNachricht { get; set; }

    public int? KNotiz { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KTelefonat { get; set; }

    public virtual TNachricht? KNachrichtNavigation { get; set; }

    public virtual TNotiz1? KNotizNavigation { get; set; }

    public virtual TTelefonat? KTelefonatNavigation { get; set; }

    public virtual TTicket KTicketNavigation { get; set; } = null!;
}
