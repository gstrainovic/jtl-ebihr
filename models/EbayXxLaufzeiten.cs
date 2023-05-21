using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayXxLaufzeiten
{
    public int SiteId { get; set; }

    public string CType { get; set; } = null!;

    public string CDuration { get; set; } = null!;
}
