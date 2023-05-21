using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEbayItemProductCompliance
{
    public int KItem { get; set; }

    public string CProfileId { get; set; } = null!;

    public virtual EbayItem KItemNavigation { get; set; } = null!;
}
