using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkProcessIteration
{
    public int KWorkProcessIteration { get; set; }

    public int KWorkProcess { get; set; }

    public int NIteration { get; set; }

    public int NTotalIterations { get; set; }

    public DateTimeOffset? DStarted { get; set; }

    public DateTimeOffset? DFinished { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KPickliste { get; set; }

    public string CProductionLotNumber { get; set; } = null!;

    public int? KCreatedWorkbenchResource { get; set; }

    public int? KLastWorkbenchResource { get; set; }

    public virtual TWorkbenchResource? KCreatedWorkbenchResourceNavigation { get; set; }

    public virtual TWorkbenchResource? KLastWorkbenchResourceNavigation { get; set; }

    public virtual TPickliste? KPicklisteNavigation { get; set; }

    public virtual TWorkProcess KWorkProcessNavigation { get; set; } = null!;

    public virtual ICollection<TWorkJob> TWorkJobs { get; set; } = new List<TWorkJob>();

    public virtual ICollection<TWorkProcessReplenishment> TWorkProcessReplenishments { get; set; } = new List<TWorkProcessReplenishment>();
}
