using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOperationStepSprache
{
    public int KOperationStep { get; set; }

    public int KSprache { get; set; }

    public string CText { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual TOperationStep KOperationStepNavigation { get; set; } = null!;
}
