using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkflowAktion
{
    public int KWorkflowAktion { get; set; }

    public int KWorkflow { get; set; }

    public string XXmlObjekt { get; set; } = null!;

    public int NPos { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
