using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCategory
{
    public int KCategory { get; set; }

    public int KChannel { get; set; }

    public string CCategoryId { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public bool NListingAllowed { get; set; }

    public int? KParentCategory { get; set; }

    public string? CParentCategory { get; set; }

    public bool NDeprecated { get; set; }

    public DateTime? DKategorieAttributeAktualisierungUtc { get; set; }

    public virtual TChannel KChannelNavigation { get; set; } = null!;

    public virtual ICollection<TCategoryAttribute> TCategoryAttributes { get; set; } = new List<TCategoryAttribute>();
}
