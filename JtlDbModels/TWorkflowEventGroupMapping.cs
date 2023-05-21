using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkflowEventGroupMapping
{
    public int KWorkflowEventGroupMapping { get; set; }

    public int KWorkflowEventGroup { get; set; }

    public int KWorkflowEvent { get; set; }
}
