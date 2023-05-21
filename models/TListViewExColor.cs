using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TListViewExColor
{
    public int KListViewExColor { get; set; }

    public int KBenutzer { get; set; }

    public int KBenutzerAdmin { get; set; }

    public int NListViewId { get; set; }

    public string CRechnername { get; set; } = null!;

    public int NColorId { get; set; }

    public int NSubColorId { get; set; }

    public string CRgb { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
