using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTicketRelation
{
    public int KTicketRelation { get; set; }

    public int KBasisticket { get; set; }

    public int KVerknuepftesTicket { get; set; }

    public DateTime DErstelldatum { get; set; }

    public int KBenutzer { get; set; }

    public virtual TTicket KBasisticketNavigation { get; set; } = null!;

    public virtual TTicket KVerknuepftesTicketNavigation { get; set; } = null!;
}
