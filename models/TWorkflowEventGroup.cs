using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkflowEventGroup
{
    public int KWorkflowEventGroup { get; set; }

    public int NObjekt { get; set; }

    public string CDisplayName { get; set; } = null!;

    public int? NSortierung { get; set; }
}
