using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvNotification
{
    public long KNotification { get; set; }

    public long? KId { get; set; }

    public string CEventId { get; set; } = null!;

    public DateTime DCreationDate { get; set; }

    public byte NSeverity { get; set; }

    public byte NType { get; set; }

    public string? CReference { get; set; }

    public bool NGelesen { get; set; }

    public int KShop { get; set; }

    public string? COrderCancellationRequestId { get; set; }

    public string? CShortMessage { get; set; }

    public string CChannel { get; set; } = null!;

    public string? CShopName { get; set; }

    public string? COfferTitle { get; set; }
}
