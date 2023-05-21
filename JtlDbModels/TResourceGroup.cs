using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TResourceGroup
{
    public int KResourceGroup { get; set; }

    public string CName { get; set; } = null!;

    public int? KResourceType { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TResourceType? KResourceTypeNavigation { get; set; }

    public virtual ICollection<TResourcesGroup> TResourcesGroups { get; set; } = new List<TResourcesGroup>();
}
