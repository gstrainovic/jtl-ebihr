using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterActualValue
{
    public int KProcessParameterActualValue { get; set; }

    public int KProcessParameterAssignment { get; set; }

    public int KActualValueObject { get; set; }

    public int? NValueInt { get; set; }

    public decimal? NValueDecimal { get; set; }

    public string? CValueText { get; set; }

    public DateTimeOffset? DValueDateTime { get; set; }

    public int? KFile { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameterAssignment1 KProcessParameterAssignmentNavigation { get; set; } = null!;
}
