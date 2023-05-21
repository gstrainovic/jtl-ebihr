using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOperationStepFile
{
    public int KOperationStepFile { get; set; }

    public int KOperationStep { get; set; }

    public int KFile { get; set; }

    public int NSort { get; set; }

    public string? CName { get; set; }

    public byte NType { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TOperationStep KOperationStepNavigation { get; set; } = null!;
}
