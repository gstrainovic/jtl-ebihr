using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkbenchResource
{
    public int KWorkbenchResource { get; set; }

    public int KResource { get; set; }

    public string? CHostName { get; set; }

    public int? KBenutzerConnected { get; set; }

    public DateTimeOffset? DConnected { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KWarenLager { get; set; }

    public byte NReservationMode { get; set; }

    public virtual TResource KResourceNavigation { get; set; } = null!;

    public virtual TWarenLager? KWarenLagerNavigation { get; set; }

    public virtual ICollection<TWorkJobBillOfMaterialsComponentStock> TWorkJobBillOfMaterialsComponentStocks { get; set; } = new List<TWorkJobBillOfMaterialsComponentStock>();

    public virtual ICollection<TWorkJobOperation> TWorkJobOperationKCreatedWorkbenchResourceNavigations { get; set; } = new List<TWorkJobOperation>();

    public virtual ICollection<TWorkJobOperation> TWorkJobOperationKLastWorkbenchResourceNavigations { get; set; } = new List<TWorkJobOperation>();

    public virtual ICollection<TWorkProcessIteration> TWorkProcessIterationKCreatedWorkbenchResourceNavigations { get; set; } = new List<TWorkProcessIteration>();

    public virtual ICollection<TWorkProcessIteration> TWorkProcessIterationKLastWorkbenchResourceNavigations { get; set; } = new List<TWorkProcessIteration>();

    public virtual ICollection<TWorkProcess> TWorkProcessKCreatedWorkbenchResourceNavigations { get; set; } = new List<TWorkProcess>();

    public virtual ICollection<TWorkProcess> TWorkProcessKCurrentWorkbenchResourceNavigations { get; set; } = new List<TWorkProcess>();

    public virtual ICollection<TWorkProcess> TWorkProcessKLastWorkbenchResourceNavigations { get; set; } = new List<TWorkProcess>();

    public virtual ICollection<TWorkbenchBin> TWorkbenchBins { get; set; } = new List<TWorkbenchBin>();
}
