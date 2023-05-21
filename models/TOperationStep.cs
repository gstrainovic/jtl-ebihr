using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOperationStep
{
    public int KOperationStep { get; set; }

    public int KOperation { get; set; }

    public int NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CName { get; set; }

    public virtual TOperation KOperationNavigation { get; set; } = null!;

    public virtual ICollection<TBillOfMaterialComponent> TBillOfMaterialComponents { get; set; } = new List<TBillOfMaterialComponent>();

    public virtual ICollection<TOperationStepFile> TOperationStepFiles { get; set; } = new List<TOperationStepFile>();

    public virtual ICollection<TOperationStepSprache> TOperationStepSpraches { get; set; } = new List<TOperationStepSprache>();

    public virtual ICollection<TWorkJobOperationStep> TWorkJobOperationSteps { get; set; } = new List<TWorkJobOperationStep>();
}
