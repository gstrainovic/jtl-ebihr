using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvProducibleProductionOrder
{
    public int KProductionOrder { get; set; }

    public string CIssueNumber { get; set; } = null!;

    public DateTimeOffset DIssueDate { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public DateTimeOffset? DDelivery { get; set; }

    public DateTimeOffset? DActualCompletion { get; set; }

    public DateTimeOffset? DActualStart { get; set; }

    public DateTimeOffset? DRelease { get; set; }

    public DateTimeOffset? DTargetCompletion { get; set; }

    public DateTimeOffset? DTargetStart { get; set; }

    public int NLotCount { get; set; }

    public decimal NLotSize { get; set; }

    public bool NCombinedLotSize { get; set; }

    public bool NTargetTotalQuantityBelowLotSizeAllowed { get; set; }

    public string? CBenutzerCreated { get; set; }

    public string? CBenutzerLastModified { get; set; }

    public string? CBenutzerReleased { get; set; }

    public string? Items { get; set; }

    public DateTime? DFilterDate { get; set; }
}
