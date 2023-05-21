using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKundenDrucktextSprache
{
    public int KKundenDrucktext { get; set; }

    public int KSprache { get; set; }

    public string? CRechnungstext { get; set; }

    public string? CAuftragstext { get; set; }

    public string? CAngebotstext { get; set; }

    public string? CGutschrifttext { get; set; }

    public string? CLieferscheintext { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
