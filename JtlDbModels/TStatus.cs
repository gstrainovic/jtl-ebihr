using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatus
{
    public int KStatus { get; set; }

    public string CName { get; set; } = null!;

    public bool NIsDefault { get; set; }

    public virtual ICollection<TAusgangskanalEmail> TAusgangskanalEmails { get; set; } = new List<TAusgangskanalEmail>();

    public virtual ICollection<TEingangskanalEmail> TEingangskanalEmailKStatusNeueAntwortNavigations { get; set; } = new List<TEingangskanalEmail>();

    public virtual ICollection<TEingangskanalEmail> TEingangskanalEmailKStatusNeuesTicketNavigations { get; set; } = new List<TEingangskanalEmail>();

    public virtual ICollection<TTicket> TTickets { get; set; } = new List<TTicket>();
}
