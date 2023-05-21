using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VMerkmal
{
    public int KMerkmal { get; set; }

    public int? NSort { get; set; }

    public byte? NGlobal { get; set; }

    public string? CName { get; set; }

    public string? CTyp { get; set; }

    public byte NMehrfachauswahl { get; set; }

    public int? KShop { get; set; }
}
