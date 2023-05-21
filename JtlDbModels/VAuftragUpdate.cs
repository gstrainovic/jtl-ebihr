using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragUpdate
{
    public int KAuftrag { get; set; }

    public int? KBestellung { get; set; }

    public int KSprache { get; set; }

    public int? KWaehrung { get; set; }

    public decimal FGuthaben { get; set; }

    public decimal FGesamtsumme { get; set; }

    public string? CBestellNr { get; set; }

    public string? CZahlungsartName { get; set; }

    public string CSendeEmail { get; set; } = null!;

    public int? KShop { get; set; }
}
