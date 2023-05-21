using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TListViewSpalten
{
    public int? KListView { get; set; }

    public int? NPos { get; set; }

    public string? CWert { get; set; }

    public int? KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
