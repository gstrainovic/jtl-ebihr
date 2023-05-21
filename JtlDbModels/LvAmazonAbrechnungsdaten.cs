using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAmazonAbrechnungsdaten
{
    public long KMessageId { get; set; }

    public string? Username { get; set; }

    public long ReportId { get; set; }

    public long SettlementId { get; set; }

    public DateTime? SettlementStartDate { get; set; }

    public DateTime? SettlementEndDate { get; set; }

    public DateTime? DepositDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string Currency { get; set; } = null!;

    public DateTime? DErstellt { get; set; }

    public int KUser { get; set; }
}
