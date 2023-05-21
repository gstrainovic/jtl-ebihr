using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TListViewExSummary
{
    public int KListViewExSummary { get; set; }

    public int KBenutzer { get; set; }

    public int KBenutzerAdmin { get; set; }

    public int NListViewId { get; set; }

    public int NSummaryId { get; set; }

    public string? CRechnername { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
