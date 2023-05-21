using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VTicketliste
{
    public int TicketKey { get; set; }

    public int CustomerKey { get; set; }

    public int LieferantKey { get; set; }

    public string? Title { get; set; }

    public string TicketId { get; set; } = null!;

    public DateTime? DatumNeuesteNachricht { get; set; }

    public DateTime? TargetDate { get; set; }

    public DateTime? ReminderDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public byte TicketPriority { get; set; }

    public int? IsInPaperbinInt { get; set; }

    public int TicketStatus { get; set; }

    public string? TicketStatusName { get; set; }

    public int NachrichtGelesenNutzer { get; set; }

    public int? AssigneeKey { get; set; }

    public string? AssigneeFullName { get; set; }

    public string? ContentOfInitialMessage { get; set; }

    public int HasAttachments { get; set; }

    public int? LastMessageDirection { get; set; }

    public int? MessagesCount { get; set; }

    public string? CustomerName { get; set; }

    public string? LieferantName { get; set; }

    public int HasUnseenChanges { get; set; }

    public string? Kundennummer { get; set; }

    public string? Lieferantennummer { get; set; }
}
