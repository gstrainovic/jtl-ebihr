using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductionOrder
{
    public int KProductionOrder { get; set; }

    public string CIssueNumber { get; set; } = null!;

    public DateTimeOffset DIssueDate { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public int KBenutzerCreated { get; set; }

    public int KBenutzerLastModified { get; set; }

    public string CProjectNumber { get; set; } = null!;

    public string CReferenceNumber { get; set; } = null!;

    public decimal FProgress { get; set; }

    public decimal NLotSize { get; set; }

    public bool NHasWarnings { get; set; }

    public DateTimeOffset? DTargetStart { get; set; }

    public DateTimeOffset? DTargetCompletion { get; set; }

    public DateTimeOffset? DActualStart { get; set; }

    public DateTimeOffset? DActualCompletion { get; set; }

    public DateTimeOffset? DDelivery { get; set; }

    public DateTimeOffset? DRelease { get; set; }

    public int? KBenutzerReleased { get; set; }

    public string CNotice { get; set; } = null!;

    public string CText { get; set; } = null!;

    public bool NCombinedLotSize { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NLotCount { get; set; }

    public bool NTargetTotalQuantityBelowLotSizeAllowed { get; set; }

    public virtual TLotPreparationProductionOrder? TLotPreparationProductionOrder { get; set; }

    public virtual ICollection<TProductionOrderFile> TProductionOrderFiles { get; set; } = new List<TProductionOrderFile>();

    public virtual ICollection<TProductionOrderLabel> TProductionOrderLabels { get; set; } = new List<TProductionOrderLabel>();

    public virtual ICollection<TProductionOrderProducible> TProductionOrderProducibles { get; set; } = new List<TProductionOrderProducible>();

    public virtual ICollection<TProductionOrderSearch> TProductionOrderSearches { get; set; } = new List<TProductionOrderSearch>();

    public virtual ICollection<TWorkProcess> TWorkProcesses { get; set; } = new List<TWorkProcess>();
}
