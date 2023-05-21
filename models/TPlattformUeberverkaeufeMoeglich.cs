using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPlattformUeberverkaeufeMoeglich
{
    public int KPlattformUeberverkaeufeMoeglich { get; set; }

    public int KArtikel { get; set; }

    public int NPlattform { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TPlattform NPlattformNavigation { get; set; } = null!;
}
