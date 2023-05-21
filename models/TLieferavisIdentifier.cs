using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLieferavisIdentifier
{
    public int KLieferavisIdentifier { get; set; }

    public int KLieferavisPaket { get; set; }

    public string CName { get; set; } = null!;

    public string CWert { get; set; } = null!;

    public virtual TLieferavisPaket KLieferavisPaketNavigation { get; set; } = null!;
}
