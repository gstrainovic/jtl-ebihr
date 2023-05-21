using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvWorkbenchResource
{
    public int KResource { get; set; }

    public string CNumber { get; set; } = null!;

    public string CName { get; set; } = null!;

    public decimal FCost { get; set; }

    public bool NInactive { get; set; }

    public byte ResourceTimeUnit { get; set; }

    public string ResourceTypeName { get; set; } = null!;

    public bool NAppoitmentRequestAutomatic { get; set; }

    public bool NDivisible { get; set; }

    public Guid? USpecialType { get; set; }

    public byte ResourceTypeTimeUnit { get; set; }

    public string? CHostName { get; set; }

    public DateTimeOffset? DConnected { get; set; }

    public int? KBenutzerConnected { get; set; }

    public string? Labels { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public string? BenutzerNameConnected { get; set; }

    public string? CWarehouseName { get; set; }

    public bool? NWarehouseAktiv { get; set; }
}
