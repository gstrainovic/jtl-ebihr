using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvUserResource
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

    public string? CLogin { get; set; }

    public string? CEmail { get; set; }

    public string? BenutzerName { get; set; }

    public string? CAbteilung { get; set; }

    public string? CMobil { get; set; }

    public string? Labels { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }
}
