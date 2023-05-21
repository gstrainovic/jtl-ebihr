using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKonfigGruppe
{
    public int KKonfiggruppe { get; set; }

    public int? NMin { get; set; }

    public int? NMax { get; set; }

    public int? NTyp { get; set; }

    public int? NSort { get; set; }

    public string? CKommentar { get; set; }

    public int? KShop { get; set; }

    public bool NDeleted { get; set; }
}
