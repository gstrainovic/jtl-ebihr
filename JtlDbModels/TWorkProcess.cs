using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkProcess
{
    public int KWorkProcess { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastAction { get; set; }

    public DateTimeOffset? DFinished { get; set; }

    public int? KCreatedWorkbenchResource { get; set; }

    public int? KCurrentWorkbenchResource { get; set; }

    public int? KBenutzerCurrent { get; set; }

    public Guid IProcessType { get; set; }

    public byte NOriginType { get; set; }

    public int? KProductionOrder { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string CProductionBatchNumber { get; set; } = null!;

    public int KWarenLager { get; set; }

    public int? KLastWorkbenchResource { get; set; }

    public virtual TWorkbenchResource? KCreatedWorkbenchResourceNavigation { get; set; }

    public virtual TWorkbenchResource? KCurrentWorkbenchResourceNavigation { get; set; }

    public virtual TWorkbenchResource? KLastWorkbenchResourceNavigation { get; set; }

    public virtual TProductionOrder? KProductionOrderNavigation { get; set; }

    public virtual ICollection<TWorkProcessIteration> TWorkProcessIterations { get; set; } = new List<TWorkProcessIteration>();

    public virtual ICollection<TWorkProcessReplenishment> TWorkProcessReplenishments { get; set; } = new List<TWorkProcessReplenishment>();

    public virtual ICollection<TWorkProcessSearch> TWorkProcessSearches { get; set; } = new List<TWorkProcessSearch>();
}
