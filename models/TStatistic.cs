using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStatistic
{
    public int KStatistics { get; set; }

    public int KStatistikVorlage { get; set; }

    public string CName { get; set; } = null!;

    public string? CDescription { get; set; }

    public int NDiagramType { get; set; }

    public bool NKeyLabelsVisible { get; set; }

    public bool NValueLabelsVisible { get; set; }

    public bool NRotateLabels { get; set; }

    public int NStripLinesVisibility { get; set; }

    public int NMajorLinesVisibility { get; set; }

    public int KBenutzer { get; set; }
}
