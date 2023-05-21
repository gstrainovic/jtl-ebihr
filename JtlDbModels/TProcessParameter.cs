using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameter
{
    public int KProcessParameter { get; set; }

    public Guid IRelation { get; set; }

    public Guid IPrimaryReference { get; set; }

    public Guid ISecondaryReference { get; set; }

    public int NFieldType { get; set; }

    public int NOrigin { get; set; }

    public string CName { get; set; } = null!;

    public string? CDescription { get; set; }

    public string? CGroupName { get; set; }

    public int NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NDeleted { get; set; }

    public virtual ICollection<TProcessParameterAssignment> TProcessParameterAssignmentKLinkedProcessParameterNavigations { get; set; } = new List<TProcessParameterAssignment>();

    public virtual ICollection<TProcessParameterAssignment> TProcessParameterAssignmentKProcessParameterNavigations { get; set; } = new List<TProcessParameterAssignment>();

    public virtual ICollection<TProcessParameterLanguage> TProcessParameterLanguages { get; set; } = new List<TProcessParameterLanguage>();
}
