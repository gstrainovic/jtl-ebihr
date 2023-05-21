using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TListViewExHeader
{
    public int KListViewExHeader { get; set; }

    public int KBenutzer { get; set; }

    public int KBenutzerAdmin { get; set; }

    public int NListViewId { get; set; }

    public string CRechnername { get; set; } = null!;

    public int NHeaderId { get; set; }

    public int NSize { get; set; }

    public int NSort { get; set; }

    public int NOrderBy { get; set; }

    public string COriginalName { get; set; } = null!;

    public string? CCustomName { get; set; }

    public byte? NRoundStellen { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
