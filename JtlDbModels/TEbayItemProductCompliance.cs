using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEbayItemProductCompliance
{
    public int KItem { get; set; }

    public string CProfileId { get; set; } = null!;

    public virtual EbayItem KItemNavigation { get; set; } = null!;
}
