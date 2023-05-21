using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkflowLog
{
    public int KWorkflowLog { get; set; }

    public int KObjektPk { get; set; }

    public int KWorkflowAktion { get; set; }

    public DateTime DDatum { get; set; }

    public string CArbeitsplatz { get; set; } = null!;

    public int KBenutzer { get; set; }

    public int NTyp { get; set; }

    public string CLog { get; set; } = null!;

    public int KWorkflow { get; set; }

    public string? CObjectId { get; set; }

    public Guid UniqueId { get; set; }
}
