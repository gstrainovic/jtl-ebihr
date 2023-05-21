using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkflowQueue
{
    public int KWorkflowQueue { get; set; }

    public int NEvent { get; set; }

    public int KWorkflow { get; set; }

    public int KObjektPk { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DStartDate { get; set; }

    public int NStatus { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
