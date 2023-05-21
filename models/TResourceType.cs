using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TResourceType
{
    public int KResourceType { get; set; }

    public string CName { get; set; } = null!;

    public bool NDivisible { get; set; }

    public bool NAppoitmentRequestAutomatic { get; set; }

    public byte NTimeUnit { get; set; }

    public int? KTimeModel { get; set; }

    public Guid? USpecialType { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TResourceGroup> TResourceGroups { get; set; } = new List<TResourceGroup>();

    public virtual ICollection<TResource> TResources { get; set; } = new List<TResource>();
}
