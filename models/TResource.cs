using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TResource
{
    public int KResource { get; set; }

    public bool NInactive { get; set; }

    public string CName { get; set; } = null!;

    public int KResourceType { get; set; }

    public int? KTimeModel { get; set; }

    public decimal FCost { get; set; }

    public byte NTimeUnit { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string CNumber { get; set; } = null!;

    public string? CDescription { get; set; }

    public virtual TResourceType KResourceTypeNavigation { get; set; } = null!;

    public virtual TTimeModel? KTimeModelNavigation { get; set; }

    public virtual ICollection<TLotPreparationLot> TLotPreparationLots { get; set; } = new List<TLotPreparationLot>();

    public virtual ICollection<TResourceAbsenteeism> TResourceAbsenteeisms { get; set; } = new List<TResourceAbsenteeism>();

    public virtual ICollection<TResourceCustomField> TResourceCustomFields { get; set; } = new List<TResourceCustomField>();

    public virtual ICollection<TResourceLabel> TResourceLabels { get; set; } = new List<TResourceLabel>();

    public virtual ICollection<TResourceSub> TResourceSubKResourceNavigations { get; set; } = new List<TResourceSub>();

    public virtual ICollection<TResourceSub> TResourceSubKSubResourceNavigations { get; set; } = new List<TResourceSub>();

    public virtual ICollection<TResourceUser> TResourceUsers { get; set; } = new List<TResourceUser>();

    public virtual ICollection<TResourcesGroup> TResourcesGroups { get; set; } = new List<TResourcesGroup>();

    public virtual ICollection<TUserResource> TUserResources { get; set; } = new List<TUserResource>();

    public virtual ICollection<TWorkbenchResource> TWorkbenchResources { get; set; } = new List<TWorkbenchResource>();
}
