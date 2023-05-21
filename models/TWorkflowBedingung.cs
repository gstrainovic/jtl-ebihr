using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkflowBedingung
{
    public int KWorkflowBedingung { get; set; }

    public int KWorkflow { get; set; }

    public string? CEigenschaft { get; set; }

    public int NOperator { get; set; }

    public string CVergleichswert { get; set; } = null!;

    public int KWorkflowEigenschaft { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NPos { get; set; }
}
