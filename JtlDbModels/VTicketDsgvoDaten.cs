using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VTicketDsgvoDaten
{
    public int KTicket { get; set; }

    public string CEindeutigeId { get; set; } = null!;

    public DateTime? DErstellung { get; set; }

    public int? KKunde { get; set; }

    public int? KLieferant { get; set; }

    public string? CTitelErsteNachricht { get; set; }
}
