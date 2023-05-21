using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTicketLabel
{
    public int KTicketLabel { get; set; }

    public int KTicket { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TLabel KLabelNavigation { get; set; } = null!;

    public virtual TTicket KTicketNavigation { get; set; } = null!;
}
