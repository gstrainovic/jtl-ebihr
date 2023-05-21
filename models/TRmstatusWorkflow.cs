using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRmstatusWorkflow
{
    public int KRmstatusWorkflow { get; set; }

    public int KRmstatus { get; set; }

    public int KWorkflow { get; set; }

    public int NTyp { get; set; }

    public int NEvent { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
