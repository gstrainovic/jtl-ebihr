using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkJobOperation
{
    public int KWorkJobOperation { get; set; }

    public int KWorkJob { get; set; }

    public int KOperation { get; set; }

    public DateTimeOffset? DStarted { get; set; }

    public DateTimeOffset? DFinished { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KPickliste { get; set; }

    public int? KBillOfMaterialComponent { get; set; }

    public int? KCreatedWorkbenchResource { get; set; }

    public int? KLastWorkbenchResource { get; set; }

    public virtual TBillOfMaterialComponent? KBillOfMaterialComponentNavigation { get; set; }

    public virtual TWorkbenchResource? KCreatedWorkbenchResourceNavigation { get; set; }

    public virtual TWorkbenchResource? KLastWorkbenchResourceNavigation { get; set; }

    public virtual TOperation KOperationNavigation { get; set; } = null!;

    public virtual TPickliste? KPicklisteNavigation { get; set; }

    public virtual TWorkJob KWorkJobNavigation { get; set; } = null!;

    public virtual ICollection<TWorkJobBillOfMaterialsComponent> TWorkJobBillOfMaterialsComponents { get; set; } = new List<TWorkJobBillOfMaterialsComponent>();

    public virtual ICollection<TWorkJobOperationStep> TWorkJobOperationSteps { get; set; } = new List<TWorkJobOperationStep>();

    public virtual ICollection<TWorkProcessReplenishment> TWorkProcessReplenishments { get; set; } = new List<TWorkProcessReplenishment>();
}
