using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvReplenishmentOrder
{
    public int KAuftrag { get; set; }

    public string CAuftragsNr { get; set; } = null!;

    public int KWorkbenchResource { get; set; }

    public DateTime DErstellt { get; set; }

    public int KBenutzer { get; set; }

    public int NState { get; set; }

    public string? CBenutzerNameErstellt { get; set; }

    public string CWorkbenchName { get; set; } = null!;

    public string CWorkbenchNummer { get; set; } = null!;

    public string? CWarenlagerName { get; set; }

    public string? COperationNumber { get; set; }

    public string? COperationName { get; set; }

    public string? CProductionLotNumber { get; set; }

    public string? CProductionBatchNumber { get; set; }
}
