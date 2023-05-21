using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterValue
{
    public int KProcessParameterValue { get; set; }

    public int KProcessParameterAssignment { get; set; }

    public int KSecondaryReference { get; set; }

    public Guid ISecondaryReference { get; set; }

    public decimal? FValueDecimal { get; set; }

    public int? NValueInt { get; set; }

    public DateTimeOffset? DValueDateTime { get; set; }

    public string? CValueText { get; set; }

    public int? KFile { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KLinkedProcessParameterAssignment { get; set; }

    public virtual TFile? KFileNavigation { get; set; }

    public virtual TProcessParameterAssignment? KLinkedProcessParameterAssignmentNavigation { get; set; }

    public virtual TProcessParameterAssignment KProcessParameterAssignmentNavigation { get; set; } = null!;
}
