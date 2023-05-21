using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExterneReservierung
{
    public int KKey { get; set; }

    public int KArtikel { get; set; }

    public int NTyp { get; set; }

    public decimal FAnzahl { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;
}
