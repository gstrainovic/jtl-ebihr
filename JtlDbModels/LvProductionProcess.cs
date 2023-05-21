using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvProductionProcess
{
    public int KWorkProcess { get; set; }

    public string CProductionBatchNumber { get; set; } = null!;

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastAction { get; set; }

    public DateTimeOffset? DFinished { get; set; }

    public string? CCurrentUser { get; set; }

    public string? CWorkbenchNumber { get; set; }

    public int NCurrentIteration { get; set; }

    public int NTotalIteration { get; set; }

    public string CCurrentOperationNumber { get; set; } = null!;

    public string CCurrentOperationName { get; set; } = null!;

    public int? KCreatedWorkbenchResource { get; set; }

    public int? KCurrentWorkbenchResource { get; set; }

    public int? KBenutzerCurrent { get; set; }

    public byte NOriginType { get; set; }

    public Guid IProcessType { get; set; }

    public int KWarenLager { get; set; }

    public bool? NHasBestBeforeDate { get; set; }

    public bool? NHasBatchNumber { get; set; }

    public bool? NHasSerialNumber { get; set; }

    public int NState { get; set; }

    public bool? NHasProcessedPositions { get; set; }

    public DateTime? DFilterDate { get; set; }

    public string? Items { get; set; }
}
