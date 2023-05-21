using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VZulauf
{
    public int KArtikel { get; set; }

    public decimal? FZulauf { get; set; }

    public DateTime? DLieferdatum { get; set; }
}
