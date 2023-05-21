using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterAssignment
{
    public int KProcessParameterAssignment { get; set; }

    public int KProcessParameter { get; set; }

    public int KPrimaryReference { get; set; }

    public Guid IPrimaryReference { get; set; }

    public int NUsageType { get; set; }

    public bool NIsRequired { get; set; }

    public decimal? FDefaultValueDecimal { get; set; }

    public int? NDefaultValueInt { get; set; }

    public string? CDefaultValueText { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NDeleted { get; set; }

    public int? KLinkedProcessParameter { get; set; }

    public virtual TProcessParameter? KLinkedProcessParameterNavigation { get; set; }

    public virtual TProcessParameter KProcessParameterNavigation { get; set; } = null!;

    public virtual ICollection<TProcessParameterValue> TProcessParameterValueKLinkedProcessParameterAssignmentNavigations { get; set; } = new List<TProcessParameterValue>();

    public virtual ICollection<TProcessParameterValue> TProcessParameterValueKProcessParameterAssignmentNavigations { get; set; } = new List<TProcessParameterValue>();
}
