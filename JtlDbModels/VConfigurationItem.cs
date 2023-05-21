using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VConfigurationItem
{
    public int KConfigurationItem { get; set; }

    public int? KProduct { get; set; }

    public string? CName { get; set; }

    public decimal FPrice { get; set; }

    public int? NSort { get; set; }

    public int NType { get; set; }

    public string? CGroupName { get; set; }

    public bool? NRequired { get; set; }

    public int NStatus { get; set; }

    public byte? NPreselection { get; set; }

    public int? KConfigurationGroup { get; set; }

    public int NInternalUse { get; set; }

    public int KSteuerklasse { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }
}
