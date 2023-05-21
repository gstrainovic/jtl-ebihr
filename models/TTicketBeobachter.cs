using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTicketBeobachter
{
    public int KTicketBeobachter { get; set; }

    public int KTicket { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TTicket KTicketNavigation { get; set; } = null!;
}
